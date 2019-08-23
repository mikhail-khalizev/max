using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_41f2-60aca9ae")]
        public void Method_1009_41f2()
        {
            ii(0x1009_41f2, 5); push(0x44);                             /* push 0x44 */
            ii(0x1009_41f7, 5); call(Definitions.sys_check_available_stack_size, 0xd_1b56); /* call 0x10165d52 */
            ii(0x1009_41fc, 1); push(ebx);                              /* push ebx */
            ii(0x1009_41fd, 1); push(ecx);                              /* push ecx */
            ii(0x1009_41fe, 1); push(edx);                              /* push edx */
            ii(0x1009_41ff, 1); push(esi);                              /* push esi */
            ii(0x1009_4200, 1); push(edi);                              /* push edi */
            ii(0x1009_4201, 1); push(ebp);                              /* push ebp */
            ii(0x1009_4202, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_4204, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1009_420a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_420d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4210, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_4213, 5); call(0x1007_6b90, -0x1_d688);           /* call 0x10076b90 */
            ii(0x1009_4218, 1); cwde();                                 /* cwde */
            ii(0x1009_4219, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_421b, 2); if(jnz(0x1009_4226, 0x9)) goto l_0x1009_4226; /* jnz 0x10094226 */
            ii(0x1009_421d, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_4221, 5); jmp(0x1009_48ff, 0x6d9); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4226:
            ii(0x1009_4226, 5); mov(ebx, 0x700);                        /* mov ebx, 0x700 */
            ii(0x1009_422b, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1009_4230, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4233, 5); call(0x1009_3e27, -0x411);              /* call 0x10093e27 */
            ii(0x1009_4238, 2); test(al, al);                           /* test al, al */
            ii(0x1009_423a, 2); if(jnz(0x1009_4255, 0x19)) goto l_0x1009_4255; /* jnz 0x10094255 */
            ii(0x1009_423c, 5); mov(ecx, 0x700);                        /* mov ecx, 0x700 */
            ii(0x1009_4241, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_4244, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1009_4249, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_424c, 5); call(0x1009_6e02, 0x2bb1);              /* call 0x10096e02 */
            ii(0x1009_4251, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4253, 2); if(jnz(0x1009_4257, 0x2)) goto l_0x1009_4257; /* jnz 0x10094257 */
        l_0x1009_4255:
            ii(0x1009_4255, 2); jmp(0x1009_4260, 0x9); goto l_0x1009_4260; /* jmp 0x10094260 */
        l_0x1009_4257:
            ii(0x1009_4257, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_425b, 5); jmp(0x1009_48ff, 0x69f); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4260:
            ii(0x1009_4260, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_4265, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_426a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_426d, 5); call(0x1009_3e27, -0x44b);              /* call 0x10093e27 */
            ii(0x1009_4272, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4274, 2); if(jnz(0x1009_428f, 0x19)) goto l_0x1009_428f; /* jnz 0x1009428f */
            ii(0x1009_4276, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_427b, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_427e, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_4283, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4286, 5); call(0x1009_6e02, 0x2b77);              /* call 0x10096e02 */
            ii(0x1009_428b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_428d, 2); if(jnz(0x1009_4291, 0x2)) goto l_0x1009_4291; /* jnz 0x10094291 */
        l_0x1009_428f:
            ii(0x1009_428f, 2); jmp(0x1009_429a, 0x9); goto l_0x1009_429a; /* jmp 0x1009429a */
        l_0x1009_4291:
            ii(0x1009_4291, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4295, 5); jmp(0x1009_48ff, 0x665); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_429a:
            ii(0x1009_429a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_429c, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1009_42a1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_42a4, 5); call(0x1009_3e27, -0x482);              /* call 0x10093e27 */
            ii(0x1009_42a9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42ab, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_42ae, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42b0, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_42b5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_42b8, 5); call(0x1009_3e27, -0x496);              /* call 0x10093e27 */
            ii(0x1009_42bd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42bf, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_42c2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42c4, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_42c9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_42cc, 5); call(0x1009_3e27, -0x4aa);              /* call 0x10093e27 */
            ii(0x1009_42d1, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42d3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_42d6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42d8, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_42dd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_42e0, 5); call(0x1009_3e27, -0x4be);              /* call 0x10093e27 */
            ii(0x1009_42e5, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42e7, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_42ea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42ec, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1009_42f1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_42f4, 5); call(0x1009_3e27, -0x4d2);              /* call 0x10093e27 */
            ii(0x1009_42f9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42fb, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_42fe, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_4301, 3); add(eax, memd[ss, ebp - 0x20]);         /* add eax, [ebp-0x20] */
            ii(0x1009_4304, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_4307, 3); add(eax, memd[ss, ebp - 0x14]);         /* add eax, [ebp-0x14] */
            ii(0x1009_430a, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1009_430d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_430f, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1009_4312, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_4316, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4318, 2); if(jle(0x1009_4322, 0x8)) goto l_0x1009_4322; /* jle 0x10094322 */
            ii(0x1009_431a, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1009_431e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4320, 2); if(jg(0x1009_4327, 0x5)) goto l_0x1009_4327; /* jg 0x10094327 */
        l_0x1009_4322:
            ii(0x1009_4322, 5); jmp(0x1009_44eb, 0x1c4); goto l_0x1009_44eb; /* jmp 0x100944eb */
        l_0x1009_4327:
            ii(0x1009_4327, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_432c, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_4331, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4334, 5); call(0x1009_3e27, -0x512);              /* call 0x10093e27 */
            ii(0x1009_4339, 2); test(al, al);                           /* test al, al */
            ii(0x1009_433b, 2); if(jnz(0x1009_4356, 0x19)) goto l_0x1009_4356; /* jnz 0x10094356 */
            ii(0x1009_433d, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_4342, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_4345, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_434a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_434d, 5); call(0x1009_6e02, 0x2ab0);              /* call 0x10096e02 */
            ii(0x1009_4352, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4354, 2); if(jnz(0x1009_4358, 0x2)) goto l_0x1009_4358; /* jnz 0x10094358 */
        l_0x1009_4356:
            ii(0x1009_4356, 2); jmp(0x1009_4361, 0x9); goto l_0x1009_4361; /* jmp 0x10094361 */
        l_0x1009_4358:
            ii(0x1009_4358, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_435c, 5); jmp(0x1009_48ff, 0x59e); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4361:
            ii(0x1009_4361, 5); mov(ebx, 0xc00);                        /* mov ebx, 0xc00 */
            ii(0x1009_4366, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1009_436b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_436e, 5); call(0x1009_3e27, -0x54c);              /* call 0x10093e27 */
            ii(0x1009_4373, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4375, 2); if(jnz(0x1009_4390, 0x19)) goto l_0x1009_4390; /* jnz 0x10094390 */
            ii(0x1009_4377, 5); mov(ecx, 0xc00);                        /* mov ecx, 0xc00 */
            ii(0x1009_437c, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_437f, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1009_4384, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4387, 5); call(0x1009_6e02, 0x2a76);              /* call 0x10096e02 */
            ii(0x1009_438c, 2); test(al, al);                           /* test al, al */
            ii(0x1009_438e, 2); if(jnz(0x1009_4392, 0x2)) goto l_0x1009_4392; /* jnz 0x10094392 */
        l_0x1009_4390:
            ii(0x1009_4390, 2); jmp(0x1009_439b, 0x9); goto l_0x1009_439b; /* jmp 0x1009439b */
        l_0x1009_4392:
            ii(0x1009_4392, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4396, 5); jmp(0x1009_48ff, 0x564); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_439b:
            ii(0x1009_439b, 5); mov(ebx, 0x1600);                       /* mov ebx, 0x1600 */
            ii(0x1009_43a0, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1009_43a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_43a8, 5); call(0x1009_3e27, -0x586);              /* call 0x10093e27 */
            ii(0x1009_43ad, 2); test(al, al);                           /* test al, al */
            ii(0x1009_43af, 2); if(jnz(0x1009_43ca, 0x19)) goto l_0x1009_43ca; /* jnz 0x100943ca */
            ii(0x1009_43b1, 5); mov(ecx, 0x1600);                       /* mov ecx, 0x1600 */
            ii(0x1009_43b6, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_43b9, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1009_43be, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_43c1, 5); call(0x1009_6e02, 0x2a3c);              /* call 0x10096e02 */
            ii(0x1009_43c6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_43c8, 2); if(jnz(0x1009_43cc, 0x2)) goto l_0x1009_43cc; /* jnz 0x100943cc */
        l_0x1009_43ca:
            ii(0x1009_43ca, 2); jmp(0x1009_43d5, 0x9); goto l_0x1009_43d5; /* jmp 0x100943d5 */
        l_0x1009_43cc:
            ii(0x1009_43cc, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_43d0, 5); jmp(0x1009_48ff, 0x52a); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_43d5:
            ii(0x1009_43d5, 5); mov(ebx, 0x1500);                       /* mov ebx, 0x1500 */
            ii(0x1009_43da, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1009_43df, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_43e2, 5); call(0x1009_3e27, -0x5c0);              /* call 0x10093e27 */
            ii(0x1009_43e7, 2); test(al, al);                           /* test al, al */
            ii(0x1009_43e9, 2); if(jnz(0x1009_4404, 0x19)) goto l_0x1009_4404; /* jnz 0x10094404 */
            ii(0x1009_43eb, 5); mov(ecx, 0x1500);                       /* mov ecx, 0x1500 */
            ii(0x1009_43f0, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_43f3, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1009_43f8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_43fb, 5); call(0x1009_6e02, 0x2a02);              /* call 0x10096e02 */
            ii(0x1009_4400, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4402, 2); if(jnz(0x1009_4406, 0x2)) goto l_0x1009_4406; /* jnz 0x10094406 */
        l_0x1009_4404:
            ii(0x1009_4404, 2); jmp(0x1009_440f, 0x9); goto l_0x1009_440f; /* jmp 0x1009440f */
        l_0x1009_4406:
            ii(0x1009_4406, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_440a, 5); jmp(0x1009_48ff, 0x4f0); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_440f:
            ii(0x1009_440f, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1009_4413, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4415, 6); if(jle(0x1009_44eb, 0xd0)) goto l_0x1009_44eb; /* jle 0x100944eb */
            ii(0x1009_441b, 5); mov(ecx, 0x1600);                       /* mov ecx, 0x1600 */
            ii(0x1009_4420, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1009_4425, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4428, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_442b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_442e, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_4434, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1009_4439, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_443b, 5); call(0x1009_c894, 0x8454);              /* call 0x1009c894 */
            ii(0x1009_4440, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_4443, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_4447, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_444a, 5); mov(esi, 0xa);                          /* mov esi, 0xa */
            ii(0x1009_444f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4451, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4454, 2); idiv(esi);                              /* idiv esi */
            ii(0x1009_4456, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_4459, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_445c, 5); call(0x1009_4165, -0x2fc);              /* call 0x10094165 */
            ii(0x1009_4461, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4463, 2); if(jz(0x1009_446e, 0x9)) goto l_0x1009_446e; /* jz 0x1009446e */
            ii(0x1009_4465, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4469, 5); jmp(0x1009_48ff, 0x491); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_446e:
            ii(0x1009_446e, 5); mov(ecx, 0x1500);                       /* mov ecx, 0x1500 */
            ii(0x1009_4473, 5); mov(esi, 0x1d);                         /* mov esi, 0x1d */
            ii(0x1009_4478, 5); mov(ebx, 0x1500);                       /* mov ebx, 0x1500 */
            ii(0x1009_447d, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1009_4482, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4485, 5); call(0x1009_3e27, -0x663);              /* call 0x10093e27 */
            ii(0x1009_448a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_448c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_448f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4492, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1009_4494, 5); call(0x1009_4165, -0x334);              /* call 0x10094165 */
            ii(0x1009_4499, 2); test(al, al);                           /* test al, al */
            ii(0x1009_449b, 2); if(jz(0x1009_44a6, 0x9)) goto l_0x1009_44a6; /* jz 0x100944a6 */
            ii(0x1009_449d, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_44a1, 5); jmp(0x1009_48ff, 0x459); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_44a6:
            ii(0x1009_44a6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_44a9, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_44ac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_44af, 5); call(0x1009_3f53, -0x561);              /* call 0x10093f53 */
            ii(0x1009_44b4, 2); test(al, al);                           /* test al, al */
            ii(0x1009_44b6, 2); if(jz(0x1009_44e0, 0x28)) goto l_0x1009_44e0; /* jz 0x100944e0 */
            ii(0x1009_44b8, 5); mov(ecx, 0x1600);                       /* mov ecx, 0x1600 */
            ii(0x1009_44bd, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1009_44c2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_44c5, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_44c8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_44cb, 5); call(0x1009_3ff1, -0x4df);              /* call 0x10093ff1 */
            ii(0x1009_44d0, 1); inc(eax);                               /* inc eax */
            ii(0x1009_44d1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_44d4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_44d7, 5); call(0x1009_4165, -0x377);              /* call 0x10094165 */
            ii(0x1009_44dc, 2); test(al, al);                           /* test al, al */
            ii(0x1009_44de, 2); if(jnz(0x1009_44e2, 0x2)) goto l_0x1009_44e2; /* jnz 0x100944e2 */
        l_0x1009_44e0:
            ii(0x1009_44e0, 2); jmp(0x1009_44eb, 0x9); goto l_0x1009_44eb; /* jmp 0x100944eb */
        l_0x1009_44e2:
            ii(0x1009_44e2, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_44e6, 5); jmp(0x1009_48ff, 0x414); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_44eb:
            ii(0x1009_44eb, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_44ef, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_44f4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_44f6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_44f9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_44fb, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_44fe, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_4501, 3); mov(eax, memd[ds, edx + 0x7]);          /* mov eax, [edx+0x7] */
            ii(0x1009_4504, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4507, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_450d, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1009_4512, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_4514, 5); call(0x1008_a064, -0xa4b5);             /* call 0x1008a064 */
            ii(0x1009_4519, 3); mov(memb[ss, ebp - 0x24], al);          /* mov [ebp-0x24], al */
            ii(0x1009_451c, 5); jmp(0x1009_4764, 0x243); goto l_0x1009_4764; /* jmp 0x10094764 */
        l_0x1009_4521:
            ii(0x1009_4521, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4526, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1009_452b, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_452f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4532, 5); call(0x1009_4165, -0x3d2);              /* call 0x10094165 */
            ii(0x1009_4537, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4539, 2); if(jz(0x1009_4544, 0x9)) goto l_0x1009_4544; /* jz 0x10094544 */
            ii(0x1009_453b, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_453f, 5); jmp(0x1009_48ff, 0x3bb); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4544:
            ii(0x1009_4544, 5); jmp(0x1009_4781, 0x238); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_4549:
            ii(0x1009_4549, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_454e, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_4553, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4556, 5); call(0x1009_3e27, -0x734);              /* call 0x10093e27 */
            ii(0x1009_455b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_455d, 2); if(jnz(0x1009_4578, 0x19)) goto l_0x1009_4578; /* jnz 0x10094578 */
            ii(0x1009_455f, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_4564, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_4567, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_456c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_456f, 5); call(0x1009_6e02, 0x288e);              /* call 0x10096e02 */
            ii(0x1009_4574, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4576, 2); if(jnz(0x1009_457a, 0x2)) goto l_0x1009_457a; /* jnz 0x1009457a */
        l_0x1009_4578:
            ii(0x1009_4578, 2); jmp(0x1009_4583, 0x9); goto l_0x1009_4583; /* jmp 0x10094583 */
        l_0x1009_457a:
            ii(0x1009_457a, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_457e, 5); jmp(0x1009_48ff, 0x37c); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4583:
            ii(0x1009_4583, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4588, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x1009_458d, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_4591, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4594, 5); call(0x1009_4165, -0x434);              /* call 0x10094165 */
            ii(0x1009_4599, 2); test(al, al);                           /* test al, al */
            ii(0x1009_459b, 2); if(jz(0x1009_45a6, 0x9)) goto l_0x1009_45a6; /* jz 0x100945a6 */
            ii(0x1009_459d, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_45a1, 5); jmp(0x1009_48ff, 0x359); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_45a6:
            ii(0x1009_45a6, 5); jmp(0x1009_4781, 0x1d6); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_45ab:
            ii(0x1009_45ab, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_45b0, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_45b5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_45b8, 5); call(0x1009_3e27, -0x796);              /* call 0x10093e27 */
            ii(0x1009_45bd, 2); test(al, al);                           /* test al, al */
            ii(0x1009_45bf, 2); if(jnz(0x1009_45da, 0x19)) goto l_0x1009_45da; /* jnz 0x100945da */
            ii(0x1009_45c1, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_45c6, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_45c9, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_45ce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_45d1, 5); call(0x1009_6e02, 0x282c);              /* call 0x10096e02 */
            ii(0x1009_45d6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_45d8, 2); if(jnz(0x1009_45dc, 0x2)) goto l_0x1009_45dc; /* jnz 0x100945dc */
        l_0x1009_45da:
            ii(0x1009_45da, 2); jmp(0x1009_45e5, 0x9); goto l_0x1009_45e5; /* jmp 0x100945e5 */
        l_0x1009_45dc:
            ii(0x1009_45dc, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_45e0, 5); jmp(0x1009_48ff, 0x31a); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_45e5:
            ii(0x1009_45e5, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_45ea, 5); mov(ebx, 0x17);                         /* mov ebx, 0x17 */
            ii(0x1009_45ef, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_45f3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_45f6, 5); call(0x1009_4165, -0x496);              /* call 0x10094165 */
            ii(0x1009_45fb, 2); test(al, al);                           /* test al, al */
            ii(0x1009_45fd, 2); if(jz(0x1009_4608, 0x9)) goto l_0x1009_4608; /* jz 0x10094608 */
            ii(0x1009_45ff, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4603, 5); jmp(0x1009_48ff, 0x2f7); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4608:
            ii(0x1009_4608, 5); jmp(0x1009_4781, 0x174); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_460d:
            ii(0x1009_460d, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4612, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1009_4617, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_461b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_461e, 5); call(0x1009_4165, -0x4be);              /* call 0x10094165 */
            ii(0x1009_4623, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4625, 2); if(jz(0x1009_4630, 0x9)) goto l_0x1009_4630; /* jz 0x10094630 */
            ii(0x1009_4627, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_462b, 5); jmp(0x1009_48ff, 0x2cf); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4630:
            ii(0x1009_4630, 5); jmp(0x1009_4781, 0x14c); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_4635:
            ii(0x1009_4635, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_463a, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1009_463f, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_4643, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4646, 5); call(0x1009_4165, -0x4e6);              /* call 0x10094165 */
            ii(0x1009_464b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_464d, 2); if(jz(0x1009_4658, 0x9)) goto l_0x1009_4658; /* jz 0x10094658 */
            ii(0x1009_464f, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4653, 5); jmp(0x1009_48ff, 0x2a7); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4658:
            ii(0x1009_4658, 5); jmp(0x1009_4781, 0x124); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_465d:
            ii(0x1009_465d, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4662, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1009_4667, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_466b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_466d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4670, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_4672, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_4674, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_4677, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_467a, 5); call(0x1009_4165, -0x51a);              /* call 0x10094165 */
            ii(0x1009_467f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4681, 2); if(jnz(0x1009_46a9, 0x26)) goto l_0x1009_46a9; /* jnz 0x100946a9 */
            ii(0x1009_4683, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4688, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1009_468d, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_4691, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4693, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4696, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_4698, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_469a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_469d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_46a0, 5); call(0x1009_4165, -0x540);              /* call 0x10094165 */
            ii(0x1009_46a5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_46a7, 2); if(jz(0x1009_46b2, 0x9)) goto l_0x1009_46b2; /* jz 0x100946b2 */
        l_0x1009_46a9:
            ii(0x1009_46a9, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_46ad, 5); jmp(0x1009_48ff, 0x24d); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_46b2:
            ii(0x1009_46b2, 5); jmp(0x1009_4781, 0xca); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_46b7:
            ii(0x1009_46b7, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_46bc, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1009_46c1, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_46c5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_46c8, 5); call(0x1009_4165, -0x568);              /* call 0x10094165 */
            ii(0x1009_46cd, 2); test(al, al);                           /* test al, al */
            ii(0x1009_46cf, 2); if(jz(0x1009_46da, 0x9)) goto l_0x1009_46da; /* jz 0x100946da */
            ii(0x1009_46d1, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_46d5, 5); jmp(0x1009_48ff, 0x225); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_46da:
            ii(0x1009_46da, 5); jmp(0x1009_4781, 0xa2); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_46df:
            ii(0x1009_46df, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_46e4, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1009_46e9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_46ec, 5); call(0x1009_3e27, -0x8ca);              /* call 0x10093e27 */
            ii(0x1009_46f1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_46f3, 2); if(jnz(0x1009_470e, 0x19)) goto l_0x1009_470e; /* jnz 0x1009470e */
            ii(0x1009_46f5, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_46fa, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_46fd, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1009_4702, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4705, 5); call(0x1009_6e02, 0x26f8);              /* call 0x10096e02 */
            ii(0x1009_470a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_470c, 2); if(jnz(0x1009_4710, 0x2)) goto l_0x1009_4710; /* jnz 0x10094710 */
        l_0x1009_470e:
            ii(0x1009_470e, 2); jmp(0x1009_4719, 0x9); goto l_0x1009_4719; /* jmp 0x10094719 */
        l_0x1009_4710:
            ii(0x1009_4710, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4714, 5); jmp(0x1009_48ff, 0x1e6); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_4719:
            ii(0x1009_4719, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_471e, 5); mov(ebx, 0x20);                         /* mov ebx, 0x20 */
            ii(0x1009_4723, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_4727, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_472a, 5); call(0x1009_4165, -0x5ca);              /* call 0x10094165 */
            ii(0x1009_472f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4731, 2); if(jz(0x1009_473c, 0x9)) goto l_0x1009_473c; /* jz 0x1009473c */
            ii(0x1009_4733, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4737, 5); jmp(0x1009_48ff, 0x1c3); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_473c:
            ii(0x1009_473c, 2); jmp(0x1009_4781, 0x43); goto l_0x1009_4781; /* jmp 0x10094781 */
        l_0x1009_473e:
            ii(0x1009_473e, 2); jmp(0x1009_4781, 0x41); goto l_0x1009_4781; /* jmp 0x10094781 */
        //  ii(0x1009_4740, 36); /* Служебная область с абсолютными адресами переходов. (0x1009_4521, 0x1009_473e, 0x1009_4549, 0x1009_45ab, 0x1009_460d, 0x1009_4635, 0x1009_465d, 0x1009_46b7, 0x1009_46df). */
        l_0x1009_4764:
            ii(0x1009_4764, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x1009_4767, 2); dec(al);                                /* dec al */
            ii(0x1009_4769, 3); mov(memb[ss, ebp - 0x28], al);          /* mov [ebp-0x28], al */
            ii(0x1009_476c, 4); cmp(memb[ss, ebp - 0x28], 0x8);         /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1009_4770, 2); if(ja(0x1009_473e, -0x34)) goto l_0x1009_473e; /* ja 0x1009473e */
            ii(0x1009_4772, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4774, 3); mov(al, memb[ss, ebp - 0x28]);          /* mov al, [ebp-0x28] */
            ii(0x1009_4777, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_477a, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1009_4740]))
            {
                case 0x1009_4521:
                    goto l_0x1009_4521;
                case 0x1009_4549:
                    goto l_0x1009_4549;
                case 0x1009_45ab:
                    goto l_0x1009_45ab;
                case 0x1009_460d:
                    goto l_0x1009_460d;
                case 0x1009_4635:
                    goto l_0x1009_4635;
                case 0x1009_465d:
                    goto l_0x1009_465d;
                case 0x1009_46b7:
                    goto l_0x1009_46b7;
                case 0x1009_46df:
                    goto l_0x1009_46df;
                case 0x1009_473e:
                    goto l_0x1009_473e;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x10094740] */
        l_0x1009_4781:
            ii(0x1009_4781, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_4783, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_4788, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_478b, 5); call(0x1009_3e27, -0x969);              /* call 0x10093e27 */
            ii(0x1009_4790, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4792, 2); if(jz(0x1009_47aa, 0x16)) goto l_0x1009_47aa; /* jz 0x100947aa */
            ii(0x1009_4794, 5); mov(ebx, 0x1400);                       /* mov ebx, 0x1400 */
            ii(0x1009_4799, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1009_479e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_47a1, 5); call(0x1009_3e27, -0x97f);              /* call 0x10093e27 */
            ii(0x1009_47a6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47a8, 2); if(jz(0x1009_47ac, 0x2)) goto l_0x1009_47ac; /* jz 0x100947ac */
        l_0x1009_47aa:
            ii(0x1009_47aa, 2); jmp(0x1009_47c5, 0x19); goto l_0x1009_47c5; /* jmp 0x100947c5 */
        l_0x1009_47ac:
            ii(0x1009_47ac, 5); mov(ecx, 0x1400);                       /* mov ecx, 0x1400 */
            ii(0x1009_47b1, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_47b4, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1009_47b9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_47bc, 5); call(0x1009_6e02, 0x2641);              /* call 0x10096e02 */
            ii(0x1009_47c1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47c3, 2); if(jnz(0x1009_47c7, 0x2)) goto l_0x1009_47c7; /* jnz 0x100947c7 */
        l_0x1009_47c5:
            ii(0x1009_47c5, 2); jmp(0x1009_47d0, 0x9); goto l_0x1009_47d0; /* jmp 0x100947d0 */
        l_0x1009_47c7:
            ii(0x1009_47c7, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_47cb, 5); jmp(0x1009_48ff, 0x12f); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_47d0:
            ii(0x1009_47d0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_47d2, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_47d7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_47da, 5); call(0x1009_3e27, -0x9b8);              /* call 0x10093e27 */
            ii(0x1009_47df, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47e1, 2); if(jz(0x1009_47f9, 0x16)) goto l_0x1009_47f9; /* jz 0x100947f9 */
            ii(0x1009_47e3, 5); mov(ebx, 0x1400);                       /* mov ebx, 0x1400 */
            ii(0x1009_47e8, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1009_47ed, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_47f0, 5); call(0x1009_3e27, -0x9ce);              /* call 0x10093e27 */
            ii(0x1009_47f5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_47f7, 2); if(jz(0x1009_47fb, 0x2)) goto l_0x1009_47fb; /* jz 0x100947fb */
        l_0x1009_47f9:
            ii(0x1009_47f9, 2); jmp(0x1009_4814, 0x19); goto l_0x1009_4814; /* jmp 0x10094814 */
        l_0x1009_47fb:
            ii(0x1009_47fb, 5); mov(ecx, 0x1400);                       /* mov ecx, 0x1400 */
            ii(0x1009_4800, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_4803, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1009_4808, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_480b, 5); call(0x1009_6e02, 0x25f2);              /* call 0x10096e02 */
            ii(0x1009_4810, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4812, 2); if(jnz(0x1009_4816, 0x2)) goto l_0x1009_4816; /* jnz 0x10094816 */
        l_0x1009_4814:
            ii(0x1009_4814, 2); jmp(0x1009_481f, 0x9); goto l_0x1009_481f; /* jmp 0x1009481f */
        l_0x1009_4816:
            ii(0x1009_4816, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_481a, 5); jmp(0x1009_48ff, 0xe0); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_481f:
            ii(0x1009_481f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_4821, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_4826, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4829, 5); call(0x1009_3e27, -0xa07);              /* call 0x10093e27 */
            ii(0x1009_482e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4830, 2); if(jz(0x1009_4848, 0x16)) goto l_0x1009_4848; /* jz 0x10094848 */
            ii(0x1009_4832, 5); mov(ebx, 0x1400);                       /* mov ebx, 0x1400 */
            ii(0x1009_4837, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1009_483c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_483f, 5); call(0x1009_3e27, -0xa1d);              /* call 0x10093e27 */
            ii(0x1009_4844, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4846, 2); if(jz(0x1009_484a, 0x2)) goto l_0x1009_484a; /* jz 0x1009484a */
        l_0x1009_4848:
            ii(0x1009_4848, 2); jmp(0x1009_4863, 0x19); goto l_0x1009_4863; /* jmp 0x10094863 */
        l_0x1009_484a:
            ii(0x1009_484a, 5); mov(ecx, 0x1400);                       /* mov ecx, 0x1400 */
            ii(0x1009_484f, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_4852, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1009_4857, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_485a, 5); call(0x1009_6e02, 0x25a3);              /* call 0x10096e02 */
            ii(0x1009_485f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4861, 2); if(jnz(0x1009_4865, 0x2)) goto l_0x1009_4865; /* jnz 0x10094865 */
        l_0x1009_4863:
            ii(0x1009_4863, 2); jmp(0x1009_486e, 0x9); goto l_0x1009_486e; /* jmp 0x1009486e */
        l_0x1009_4865:
            ii(0x1009_4865, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4869, 5); jmp(0x1009_48ff, 0x91); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_486e:
            ii(0x1009_486e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_4870, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1009_4875, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_4878, 5); call(0x1009_3e27, -0xa56);              /* call 0x10093e27 */
            ii(0x1009_487d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_487f, 2); if(jz(0x1009_4897, 0x16)) goto l_0x1009_4897; /* jz 0x10094897 */
            ii(0x1009_4881, 5); mov(ebx, 0x1d00);                       /* mov ebx, 0x1d00 */
            ii(0x1009_4886, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1009_488b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_488e, 5); call(0x1009_3e27, -0xa6c);              /* call 0x10093e27 */
            ii(0x1009_4893, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4895, 2); if(jz(0x1009_4899, 0x2)) goto l_0x1009_4899; /* jz 0x10094899 */
        l_0x1009_4897:
            ii(0x1009_4897, 2); jmp(0x1009_48b2, 0x19); goto l_0x1009_48b2; /* jmp 0x100948b2 */
        l_0x1009_4899:
            ii(0x1009_4899, 5); mov(ecx, 0x1d00);                       /* mov ecx, 0x1d00 */
            ii(0x1009_489e, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_48a1, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1009_48a6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_48a9, 5); call(0x1009_6e02, 0x2554);              /* call 0x10096e02 */
            ii(0x1009_48ae, 2); test(al, al);                           /* test al, al */
            ii(0x1009_48b0, 2); if(jnz(0x1009_48b4, 0x2)) goto l_0x1009_48b4; /* jnz 0x100948b4 */
        l_0x1009_48b2:
            ii(0x1009_48b2, 2); jmp(0x1009_48ba, 0x6); goto l_0x1009_48ba; /* jmp 0x100948ba */
        l_0x1009_48b4:
            ii(0x1009_48b4, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_48b8, 2); jmp(0x1009_48ff, 0x45); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_48ba:
            ii(0x1009_48ba, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1009_48be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_48c0, 2); if(jle(0x1009_48d8, 0x16)) goto l_0x1009_48d8; /* jle 0x100948d8 */
            ii(0x1009_48c2, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_48c7, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_48cc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_48cf, 5); call(0x1009_3e27, -0xaad);              /* call 0x10093e27 */
            ii(0x1009_48d4, 2); test(al, al);                           /* test al, al */
            ii(0x1009_48d6, 2); if(jz(0x1009_48da, 0x2)) goto l_0x1009_48da; /* jz 0x100948da */
        l_0x1009_48d8:
            ii(0x1009_48d8, 2); jmp(0x1009_48f3, 0x19); goto l_0x1009_48f3; /* jmp 0x100948f3 */
        l_0x1009_48da:
            ii(0x1009_48da, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_48df, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_48e2, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_48e7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_48ea, 5); call(0x1009_6e02, 0x2513);              /* call 0x10096e02 */
            ii(0x1009_48ef, 2); test(al, al);                           /* test al, al */
            ii(0x1009_48f1, 2); if(jnz(0x1009_48f5, 0x2)) goto l_0x1009_48f5; /* jnz 0x100948f5 */
        l_0x1009_48f3:
            ii(0x1009_48f3, 2); jmp(0x1009_48fb, 0x6); goto l_0x1009_48fb; /* jmp 0x100948fb */
        l_0x1009_48f5:
            ii(0x1009_48f5, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_48f9, 2); jmp(0x1009_48ff, 0x4); goto l_0x1009_48ff; /* jmp 0x100948ff */
        l_0x1009_48fb:
            ii(0x1009_48fb, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1009_48ff:
            ii(0x1009_48ff, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_4902, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_4904, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_4905, 1); pop(edi);                               /* pop edi */
            ii(0x1009_4906, 1); pop(esi);                               /* pop esi */
            ii(0x1009_4907, 1); pop(edx);                               /* pop edx */
            ii(0x1009_4908, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_4909, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_490a, 1); ret();                                  /* ret */
        }
    }
}
