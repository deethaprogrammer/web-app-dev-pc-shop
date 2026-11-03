# PC Webshop

## Run it

Requirements: [Docker Desktop](https://www.docker.com/products/docker-desktop/) (running) and VS Code.

1. Open the project folder in VS Code and open a terminal (**Terminal → New Terminal**).

2. Copy the example env file:

   ```bash
   cp .env.example .env
   ```

3. Open `.env` and set your own database password:

   ```env
   POSTGRES_PASSWORD=change-me
   ```

4. Build and start everything:

   ```bash
   docker compose up -d --build
   ```

5. Open the app:
   - Frontend: http://localhost:3000
   - Backend: http://localhost:5124

(Use the ports from your `.env` if you changed them.)

## Stop it

```bash
docker compose down
```