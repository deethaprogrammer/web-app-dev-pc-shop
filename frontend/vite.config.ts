import react from '@vitejs/plugin-react'
import { defineConfig } from 'vite'
import eslint from "vite-plugin-eslint2"
import tailwindcss from "@tailwindcss/vite"

// https://vite.dev/config/
export default defineConfig({
  plugins: [
    react(),
    eslint(),
    tailwindcss()
  ],
})
