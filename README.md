{
  "openapi": "3.0.1",
  "info": {
    "title": "API",
    "version": "1.0"
  },
  "paths": {
    "/api/Basket": {
      "get": {
        "tags": [
          "Basket"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "query",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/CustomerBasket"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/CustomerBasket"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/CustomerBasket"
                }
              }
            }
          }
        }
      },
      "post": {
        "tags": [
          "Basket"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/CustomerBasket"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/CustomerBasket"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/CustomerBasket"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/CustomerBasket"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/CustomerBasket"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/CustomerBasket"
                }
              }
            }
          }
        }
      },
      "delete": {
        "tags": [
          "Basket"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "query",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Buggy/notfound": {
      "get": {
        "tags": [
          "Buggy"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Buggy/servererror": {
      "get": {
        "tags": [
          "Buggy"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Buggy/badrequest": {
      "get": {
        "tags": [
          "Buggy"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Buggy/badrequest/{id}": {
      "get": {
        "tags": [
          "Buggy"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Products": {
      "get": {
        "tags": [
          "Products"
        ],
        "parameters": [
          {
            "name": "PageIndex",
            "in": "query",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "PageSize",
            "in": "query",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "BrandId",
            "in": "query",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "TypeId",
            "in": "query",
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          },
          {
            "name": "Sort",
            "in": "query",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "Search",
            "in": "query",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/ProductToReturnDtoPagination"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProductToReturnDtoPagination"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProductToReturnDtoPagination"
                }
              }
            }
          }
        }
      }
    },
    "/api/Products/{id}": {
      "get": {
        "tags": [
          "Products"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/ProductToReturnDto"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProductToReturnDto"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProductToReturnDto"
                }
              }
            }
          },
          "404": {
            "description": "Not Found",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/ApiResponse"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ApiResponse"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/ApiResponse"
                }
              }
            }
          }
        }
      }
    },
    "/api/Products/brands": {
      "get": {
        "tags": [
          "Products"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/ProductBrand"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/ProductBrand"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/ProductBrand"
                  }
                }
              }
            }
          }
        }
      }
    },
    "/api/Products/types": {
      "get": {
        "tags": [
          "Products"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/ProductType"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/ProductType"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/ProductType"
                  }
                }
              }
            }
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "ApiResponse": {
        "type": "object",
        "properties": {
          "statusCode": {
            "type": "integer",
            "format": "int32"
          },
          "message": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "BasketItem": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "productName": {
            "type": "string",
            "nullable": true
          },
          "price": {
            "type": "number",
            "format": "double"
          },
          "quantity": {
            "type": "integer",
            "format": "int32"
          },
          "pictureUrl": {
            "type": "string",
            "nullable": true
          },
          "brand": {
            "type": "string",
            "nullable": true
          },
          "type": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "CustomerBasket": {
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "nullable": true
          },
          "items": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/BasketItem"
            },
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "ProductBrand": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "name": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "ProductToReturnDto": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "name": {
            "type": "string",
            "nullable": true
          },
          "description": {
            "type": "string",
            "nullable": true
          },
          "price": {
            "type": "number",
            "format": "double"
          },
          "pictureUrl": {
            "type": "string",
            "nullable": true
          },
          "productType": {
            "type": "string",
            "nullable": true
          },
          "productBrand": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "ProductToReturnDtoPagination": {
        "type": "object",
        "properties": {
          "pageIndex": {
            "type": "integer",
            "format": "int32"
          },
          "pageSize": {
            "type": "integer",
            "format": "int32"
          },
          "count": {
            "type": "integer",
            "format": "int32"
          },
          "data": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/ProductToReturnDto"
            },
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "ProductType": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "name": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      }
    }
  }
}
