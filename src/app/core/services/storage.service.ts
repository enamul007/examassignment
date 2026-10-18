import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  private readonly keys = {
    ACCESS_TOKEN: 'accessToken',
    REFRESH_TOKEN: 'refreshToken',
    USER_ROLE: 'role'
  } as const;

  getItem(key: keyof typeof this.keys): string | null {
    try {
      return localStorage.getItem(this.keys[key]);
    } catch (error) {
      console.error(`Error reading ${key} from localStorage`, error);
      return null;
    }
  }

  setItem(key: keyof typeof this.keys, value: string): void {
    try {
      localStorage.setItem(this.keys[key], value);
    } catch (error) {
      console.error(`Error saving ${key} to localStorage`, error);
    }
  }

  removeItem(key: keyof typeof this.keys): void {
    try {
      localStorage.removeItem(this.keys[key]);
    } catch (error) {
      console.error(`Error removing ${key} from localStorage`, error);
    }
  }

  clearAll(): void {
    try {
      Object.values(this.keys).forEach(key => localStorage.removeItem(key));
    } catch (error) {
      console.error('Error clearing storage', error);
    }
  }
}