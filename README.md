# PC Webshop

## Dependencies
- [Docker](https://www.docker.com/get-started/)
- A Editor of your choice

## Getting set up
1. Open the project in your preferred editor
2. Copy the ```.env.example``` file to a own special ```.env``` file
3. Open `.env` and set your own values
4. Build and start everything:
    ```bash
    # to build everything detached
    docker compose up -d --build

    # if you just want to build one service (example uses frontend)
    docker compose up -d --build frontend
    ```
5. Open the app:
   - Frontend: http://localhost:${FRONTEND_PORT}
   - Backend: http://localhost:${BACKEND_PORT}

(Use the ports from your `.env` if you changed them.)

## Stopping the containers

to stop the container you can run the following command:
```bash
# to keep the volume saved:
docker compose down

# to also delete the volume
docker compose down -v
```
