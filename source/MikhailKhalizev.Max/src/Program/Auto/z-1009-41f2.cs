using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_41f2-f7af5a92")]
        public void Method_1009_41f2()
        {
            ii(0x1009_41f2, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1009_41f7, 5); calld(Definitions.sys_check_available_stack_size, 0xd_1b56); /* call 0x10165d52 */
            ii(0x1009_41fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_41fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_41fe, 1); pushd(edx);                             /* push edx */
            ii(0x1009_41ff, 1); pushd(esi);                             /* push esi */
            ii(0x1009_4200, 1); pushd(edi);                             /* push edi */
            ii(0x1009_4201, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_4202, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_4204, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1009_420a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_420d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4210, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_4213, 5); calld(0x1007_6b90, -0x1_d688);          /* call 0x10076b90 */
            ii(0x1009_4218, 1); cwde();                                 /* cwde */
            ii(0x1009_4219, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_421b, 2); if(jnzd(0x1009_4226, 0x9)) goto l_0x1009_4226; /* jnz 0x10094226 */
            ii(0x1009_421d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_4221, 5); if(jmpd_func(0x1009_48ff, 0x6d9)) return; /* jmp 0x100948ff */
        l_0x1009_4226:
            ii(0x1009_4226, 5); mov(ebx, 0x700);                        /* mov ebx, 0x700 */
            ii(0x1009_422b, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1009_4230, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4233, 5); calld(0x1009_3e27, -0x411);             /* call 0x10093e27 */
            ii(0x1009_4238, 2); test(al, al);                           /* test al, al */
            ii(0x1009_423a, 2); if(jnzd(0x1009_4255, 0x19)) goto l_0x1009_4255; /* jnz 0x10094255 */
            ii(0x1009_423c, 5); mov(ecx, 0x700);                        /* mov ecx, 0x700 */
            ii(0x1009_4241, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_4244, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1009_4249, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_424c, 5); calld(0x1009_6e02, 0x2bb1);             /* call 0x10096e02 */
            ii(0x1009_4251, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4253, 2); if(jnzd(0x1009_4257, 0x2)) goto l_0x1009_4257; /* jnz 0x10094257 */
        l_0x1009_4255:
            ii(0x1009_4255, 2); jmpd(0x1009_4260, 0x9); goto l_0x1009_4260; /* jmp 0x10094260 */
        l_0x1009_4257:
            ii(0x1009_4257, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_425b, 5); if(jmpd_func(0x1009_48ff, 0x69f)) return; /* jmp 0x100948ff */
        l_0x1009_4260:
            ii(0x1009_4260, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_4265, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_426a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_426d, 5); calld(0x1009_3e27, -0x44b);             /* call 0x10093e27 */
            ii(0x1009_4272, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4274, 2); if(jnzd(0x1009_428f, 0x19)) goto l_0x1009_428f; /* jnz 0x1009428f */
            ii(0x1009_4276, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_427b, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_427e, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_4283, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4286, 5); calld(0x1009_6e02, 0x2b77);             /* call 0x10096e02 */
            ii(0x1009_428b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_428d, 2); if(jnzd(0x1009_4291, 0x2)) goto l_0x1009_4291; /* jnz 0x10094291 */
        l_0x1009_428f:
            ii(0x1009_428f, 2); jmpd(0x1009_429a, 0x9); goto l_0x1009_429a; /* jmp 0x1009429a */
        l_0x1009_4291:
            ii(0x1009_4291, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4295, 5); if(jmpd_func(0x1009_48ff, 0x665)) return; /* jmp 0x100948ff */
        l_0x1009_429a:
            ii(0x1009_429a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_429c, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1009_42a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_42a4, 5); calld(0x1009_3e27, -0x482);             /* call 0x10093e27 */
            ii(0x1009_42a9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42ab, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_42ae, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42b0, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1009_42b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_42b8, 5); calld(0x1009_3e27, -0x496);             /* call 0x10093e27 */
            ii(0x1009_42bd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42bf, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_42c2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42c4, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_42c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_42cc, 5); calld(0x1009_3e27, -0x4aa);             /* call 0x10093e27 */
            ii(0x1009_42d1, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42d3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_42d6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42d8, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1009_42dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_42e0, 5); calld(0x1009_3e27, -0x4be);             /* call 0x10093e27 */
            ii(0x1009_42e5, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42e7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_42ea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_42ec, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1009_42f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_42f4, 5); calld(0x1009_3e27, -0x4d2);             /* call 0x10093e27 */
            ii(0x1009_42f9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_42fb, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_42fe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_4301, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x1009_4304, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_4307, 3); add(eax, memd_a32[ss, ebp - 0x14]);     /* add eax, [ebp-0x14] */
            ii(0x1009_430a, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1009_430d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_430f, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1009_4312, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1009_4316, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4318, 2); if(jled(0x1009_4322, 0x8)) goto l_0x1009_4322; /* jle 0x10094322 */
            ii(0x1009_431a, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_431e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4320, 2); if(jgd(0x1009_4327, 0x5)) goto l_0x1009_4327; /* jg 0x10094327 */
        l_0x1009_4322:
            ii(0x1009_4322, 5); jmpd(0x1009_44eb, 0x1c4); goto l_0x1009_44eb; /* jmp 0x100944eb */
        l_0x1009_4327:
            ii(0x1009_4327, 5); mov(ebx, 0x1300);                       /* mov ebx, 0x1300 */
            ii(0x1009_432c, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_4331, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4334, 5); calld(0x1009_3e27, -0x512);             /* call 0x10093e27 */
            ii(0x1009_4339, 2); test(al, al);                           /* test al, al */
            ii(0x1009_433b, 2); if(jnzd(0x1009_4356, 0x19)) goto l_0x1009_4356; /* jnz 0x10094356 */
            ii(0x1009_433d, 5); mov(ecx, 0x1300);                       /* mov ecx, 0x1300 */
            ii(0x1009_4342, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_4345, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1009_434a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_434d, 5); calld(0x1009_6e02, 0x2ab0);             /* call 0x10096e02 */
            ii(0x1009_4352, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4354, 2); if(jnzd(0x1009_4358, 0x2)) goto l_0x1009_4358; /* jnz 0x10094358 */
        l_0x1009_4356:
            ii(0x1009_4356, 2); jmpd(0x1009_4361, 0x9); goto l_0x1009_4361; /* jmp 0x10094361 */
        l_0x1009_4358:
            ii(0x1009_4358, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_435c, 5); if(jmpd_func(0x1009_48ff, 0x59e)) return; /* jmp 0x100948ff */
        l_0x1009_4361:
            ii(0x1009_4361, 5); mov(ebx, 0xc00);                        /* mov ebx, 0xc00 */
            ii(0x1009_4366, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1009_436b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_436e, 5); calld(0x1009_3e27, -0x54c);             /* call 0x10093e27 */
            ii(0x1009_4373, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4375, 2); if(jnzd(0x1009_4390, 0x19)) goto l_0x1009_4390; /* jnz 0x10094390 */
            ii(0x1009_4377, 5); mov(ecx, 0xc00);                        /* mov ecx, 0xc00 */
            ii(0x1009_437c, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_437f, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1009_4384, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4387, 5); calld(0x1009_6e02, 0x2a76);             /* call 0x10096e02 */
            ii(0x1009_438c, 2); test(al, al);                           /* test al, al */
            ii(0x1009_438e, 2); if(jnzd(0x1009_4392, 0x2)) goto l_0x1009_4392; /* jnz 0x10094392 */
        l_0x1009_4390:
            ii(0x1009_4390, 2); jmpd(0x1009_439b, 0x9); goto l_0x1009_439b; /* jmp 0x1009439b */
        l_0x1009_4392:
            ii(0x1009_4392, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4396, 5); if(jmpd_func(0x1009_48ff, 0x564)) return; /* jmp 0x100948ff */
        l_0x1009_439b:
            ii(0x1009_439b, 5); mov(ebx, 0x1600);                       /* mov ebx, 0x1600 */
            ii(0x1009_43a0, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1009_43a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_43a8, 5); calld(0x1009_3e27, -0x586);             /* call 0x10093e27 */
            ii(0x1009_43ad, 2); test(al, al);                           /* test al, al */
            ii(0x1009_43af, 2); if(jnzd(0x1009_43ca, 0x19)) goto l_0x1009_43ca; /* jnz 0x100943ca */
            ii(0x1009_43b1, 5); mov(ecx, 0x1600);                       /* mov ecx, 0x1600 */
            ii(0x1009_43b6, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_43b9, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1009_43be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_43c1, 5); calld(0x1009_6e02, 0x2a3c);             /* call 0x10096e02 */
            ii(0x1009_43c6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_43c8, 2); if(jnzd(0x1009_43cc, 0x2)) goto l_0x1009_43cc; /* jnz 0x100943cc */
        l_0x1009_43ca:
            ii(0x1009_43ca, 2); jmpd(0x1009_43d5, 0x9); goto l_0x1009_43d5; /* jmp 0x100943d5 */
        l_0x1009_43cc:
            ii(0x1009_43cc, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_43d0, 5); if(jmpd_func(0x1009_48ff, 0x52a)) return; /* jmp 0x100948ff */
        l_0x1009_43d5:
            ii(0x1009_43d5, 5); mov(ebx, 0x1500);                       /* mov ebx, 0x1500 */
            ii(0x1009_43da, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1009_43df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_43e2, 5); calld(0x1009_3e27, -0x5c0);             /* call 0x10093e27 */
            ii(0x1009_43e7, 2); test(al, al);                           /* test al, al */
            ii(0x1009_43e9, 2); if(jnzd(0x1009_4404, 0x19)) goto l_0x1009_4404; /* jnz 0x10094404 */
            ii(0x1009_43eb, 5); mov(ecx, 0x1500);                       /* mov ecx, 0x1500 */
            ii(0x1009_43f0, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_43f3, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1009_43f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_43fb, 5); calld(0x1009_6e02, 0x2a02);             /* call 0x10096e02 */
            ii(0x1009_4400, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4402, 2); if(jnzd(0x1009_4406, 0x2)) goto l_0x1009_4406; /* jnz 0x10094406 */
        l_0x1009_4404:
            ii(0x1009_4404, 2); jmpd(0x1009_440f, 0x9); goto l_0x1009_440f; /* jmp 0x1009440f */
        l_0x1009_4406:
            ii(0x1009_4406, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_440a, 5); if(jmpd_func(0x1009_48ff, 0x4f0)) return; /* jmp 0x100948ff */
        l_0x1009_440f:
            ii(0x1009_440f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1009_4413, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4415, 6); if(jled(0x1009_44eb, 0xd0)) goto l_0x1009_44eb; /* jle 0x100944eb */
            ii(0x1009_441b, 5); mov(ecx, 0x1600);                       /* mov ecx, 0x1600 */
            ii(0x1009_4420, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1009_4425, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4428, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_442b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_442e, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_4434, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1009_4439, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_443b, 5); calld(0x1009_c894, 0x8454);             /* call 0x1009c894 */
            ii(0x1009_4440, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_4443, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_4447, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_444a, 5); mov(esi, 0xa);                          /* mov esi, 0xa */
            ii(0x1009_444f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4451, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4454, 2); idiv(esi);                              /* idiv esi */
            ii(0x1009_4456, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_4459, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_445c, 5); calld(0x1009_4165, -0x2fc);             /* call 0x10094165 */
            ii(0x1009_4461, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4463, 2); if(jzd(0x1009_446e, 0x9)) goto l_0x1009_446e; /* jz 0x1009446e */
            ii(0x1009_4465, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_4469, 5); if(jmpd_func(0x1009_48ff, 0x491)) return; /* jmp 0x100948ff */
        l_0x1009_446e:
            ii(0x1009_446e, 5); mov(ecx, 0x1500);                       /* mov ecx, 0x1500 */
            ii(0x1009_4473, 5); mov(esi, 0x1d);                         /* mov esi, 0x1d */
            ii(0x1009_4478, 5); mov(ebx, 0x1500);                       /* mov ebx, 0x1500 */
            ii(0x1009_447d, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1009_4482, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4485, 5); calld(0x1009_3e27, -0x663);             /* call 0x10093e27 */
            ii(0x1009_448a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_448c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_448f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_4492, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1009_4494, 5); calld(0x1009_4165, -0x334);             /* call 0x10094165 */
            ii(0x1009_4499, 2); test(al, al);                           /* test al, al */
            ii(0x1009_449b, 2); if(jzd(0x1009_44a6, 0x9)) goto l_0x1009_44a6; /* jz 0x100944a6 */
            ii(0x1009_449d, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_44a1, 5); if(jmpd_func(0x1009_48ff, 0x459)) return; /* jmp 0x100948ff */
        l_0x1009_44a6:
            ii(0x1009_44a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_44a9, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_44ac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_44af, 5); calld(0x1009_3f53, -0x561);             /* call 0x10093f53 */
            ii(0x1009_44b4, 2); test(al, al);                           /* test al, al */
            ii(0x1009_44b6, 2); if(jzd(0x1009_44e0, 0x28)) goto l_0x1009_44e0; /* jz 0x100944e0 */
            ii(0x1009_44b8, 5); mov(ecx, 0x1600);                       /* mov ecx, 0x1600 */
            ii(0x1009_44bd, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1009_44c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_44c5, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_44c8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_44cb, 5); calld(0x1009_3ff1, -0x4df);             /* call 0x10093ff1 */
            ii(0x1009_44d0, 1); inc(eax);                               /* inc eax */
            ii(0x1009_44d1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_44d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_44d7, 5); calld(0x1009_4165, -0x377);             /* call 0x10094165 */
            ii(0x1009_44dc, 2); test(al, al);                           /* test al, al */
            ii(0x1009_44de, 2); if(jnzd(0x1009_44e2, 0x2)) goto l_0x1009_44e2; /* jnz 0x100944e2 */
        l_0x1009_44e0:
            ii(0x1009_44e0, 2); jmpd(0x1009_44eb, 0x9); goto l_0x1009_44eb; /* jmp 0x100944eb */
        l_0x1009_44e2:
            ii(0x1009_44e2, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_44e6, 5); if(jmpd_func(0x1009_48ff, 0x414)) return; /* jmp 0x100948ff */
        l_0x1009_44eb:
            ii(0x1009_44eb, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_44ef, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_44f4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_44f6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_44f9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_44fb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_44fe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_4501, 3); mov(eax, memd_a32[ds, edx + 0x7]);      /* mov eax, [edx+0x7] */
            ii(0x1009_4504, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4507, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_450d, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1009_4512, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_4514, 5); calld(0x1008_a064, -0xa4b5);            /* call 0x1008a064 */
            ii(0x1009_4519, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1009_451c, 5); if(jmpd_func(0x1009_4764, 0x243)) return; /* jmp 0x10094764 */
        }
    }
}
