﻿global using Adnc.Infra.Core.Interfaces;
global using Adnc.Infra.EventBus.RabbitMq;
global using Adnc.Infra.IdGenerater.Yitter;
global using Adnc.Infra.IRepositories;
global using Adnc.Infra.Redis;
global using Adnc.Infra.Redis.Caching;
global using Adnc.Infra.Redis.Caching.Configurations;
global using Adnc.Infra.Redis.Caching.Core.Interceptor;
global using Adnc.Demo.Maint.Application.Cache;
global using Adnc.Demo.Maint.Application.Dtos;
global using Adnc.Demo.Maint.Repository.Entities;
global using Adnc.Shared;
global using Adnc.Shared.Application.BloomFilter;
global using Adnc.Shared.Application.Caching;
global using Adnc.Shared.Application.Contracts.Attributes;
global using Adnc.Shared.Application.Contracts.Dtos;
global using Adnc.Shared.Application.Contracts.Interfaces;
global using Adnc.Shared.Application.Contracts.ResultModels;
global using Adnc.Shared.Application.Registrar;
global using Adnc.Shared.Application.Services;
global using Adnc.Demo.Shared.Const;
global using Adnc.Demo.Shared.Const.Caching.Maint;
global using Adnc.Demo.Shared.Const.Entity.Maint;
global using Adnc.Demo.Shared.Const.Mq;
global using Adnc.Shared.Repository.MongoEntities;
global using Adnc.Demo.Shared.Rpc.Http.Services;
global using AutoMapper;
global using FluentValidation;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using MongoDB.Driver;
global using System.Linq.Expressions;
global using System.Net;
global using System.Reflection;
global using System.Text.Json;
