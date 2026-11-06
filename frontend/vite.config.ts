import react from '@vitejs/plugin-react'
import { defineConfig } from 'vite'
import eslint from "vite-plugin-eslint2"
import tailwindcss from "@tailwindcss/vite"
import { fileURLToPath, URL } from "node:url";

// https://vite.dev/config/
export default defineConfig({
  plugins: [
    react(),
    eslint(),
    tailwindcss()
  ],
  resolve: {
      alias: {
          "#lib": fileURLToPath(
            new URL("./src/lib", import.meta.url)
          ),
          "#assets": fileURLToPath(
            new URL("./src/assets", import.meta.url)
          ),
          "#pages": fileURLToPath(
            new URL("./src/pages", import.meta.url)
          ),
      }
  }
})
