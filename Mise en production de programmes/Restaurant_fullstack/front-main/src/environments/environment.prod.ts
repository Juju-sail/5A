import {Environment} from "./environment.interface";

export const environment: Environment = {
  production: true,
  backendUrl: '{{ BACKEND_URL }}'
};
