using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_41c6-4f0490")]
        public void Method_1014_41c6()
        {
            ii(0x1014_41c6, 5); push(0x44);                             /* push 0x44 */
            ii(0x1014_41cb, 5); call(Definitions.sys_check_available_stack_size, 0x2_1b82); /* call 0x10165d52 */
            ii(0x1014_41d0, 1); push(ebx);                              /* push ebx */
            ii(0x1014_41d1, 1); push(ecx);                              /* push ecx */
            ii(0x1014_41d2, 1); push(esi);                              /* push esi */
            ii(0x1014_41d3, 1); push(edi);                              /* push edi */
            ii(0x1014_41d4, 1); push(ebp);                              /* push ebp */
            ii(0x1014_41d5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_41d7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_41dd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_41e0, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_41e3, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1014_41e8, 5); call(/* sys */ 0x1016_a24c, 0x2_605f);  /* call 0x1016a24c */
            ii(0x1014_41ed, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_41f2, 5); call(0x1012_0d94, -0x2_3463);           /* call 0x10120d94 */
            ii(0x1014_41f7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_41fa, 5); call(0x1007_6204, -0xc_dffb);           /* call 0x10076204 */
            ii(0x1014_41ff, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4202, 3); add(ebx, 0x4e);                         /* add ebx, 0x4e */
            ii(0x1014_4205, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4207, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_4209, 5); call(0x100a_b2a8, -0x9_8f66);           /* call 0x100ab2a8 */
            ii(0x1014_420e, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_4211, 7); mov(memd[ds, ecx + 0x1a], 0x280);       /* mov dword [ecx+0x1a], 0x280 */
            ii(0x1014_4218, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_421b, 6); mov(memd[ds, ecx], 0);                  /* mov dword [ecx], 0x0 */
            ii(0x1014_4221, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_4224, 7); mov(memd[ds, ecx + 0x4], 0);            /* mov dword [ecx+0x4], 0x0 */
            ii(0x1014_422b, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_422e, 7); mov(memd[ds, ecx + 0x8], 0x27f);        /* mov dword [ecx+0x8], 0x27f */
            ii(0x1014_4235, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_4238, 7); mov(memd[ds, ecx + 0xc], 0x1df);        /* mov dword [ecx+0xc], 0x1df */
            ii(0x1014_423f, 2); push(0);                                /* push 0x0 */
            ii(0x1014_4241, 2); push(0);                                /* push 0x0 */
            ii(0x1014_4243, 5); mov(ecx, 0x1e0);                        /* mov ecx, 0x1e0 */
            ii(0x1014_4248, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1014_424d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_424f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_4251, 5); call(/* sys */ 0x1016_6764, 0x2_250e);  /* call 0x10166764 */
            ii(0x1014_4256, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_4259, 3); mov(memd[ds, ecx + 0x12], eax);         /* mov [ecx+0x12], eax */
            ii(0x1014_425c, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_425f, 3); mov(eax, memd[ds, ecx + 0x12]);         /* mov eax, [ecx+0x12] */
            ii(0x1014_4262, 5); call(/* sys */ 0x1016_7dd4, 0x2_3b6d);  /* call 0x10167dd4 */
            ii(0x1014_4267, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1014_426a, 3); mov(memd[ds, ecx + 0x16], eax);         /* mov [ecx+0x16], eax */
            ii(0x1014_426d, 5); call(0x100d_533c, -0x6_ef36);           /* call 0x100d533c */
            ii(0x1014_4272, 1); cwde();                                 /* cwde */
            ii(0x1014_4273, 1); push(eax);                              /* push eax */
            ii(0x1014_4274, 5); call(0x100d_5360, -0x6_ef19);           /* call 0x100d5360 */
            ii(0x1014_4279, 1); cwde();                                 /* cwde */
            ii(0x1014_427a, 1); push(eax);                              /* push eax */
            ii(0x1014_427b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_427d, 1); push(eax);                              /* push eax */
            ii(0x1014_427e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_4280, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4283, 3); mov(ebx, memd[ds, ebx + 0x18]);         /* mov ebx, [ebx+0x18] */
            ii(0x1014_4286, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_4289, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_428c, 5); mov(eax, 0x6bc);                        /* mov eax, 0x6bc */
            ii(0x1014_4291, 5); call(0x100e_8c51, -0x5_b645);           /* call 0x100e8c51 */
            ii(0x1014_4296, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1014_4299, 2); if(jnz(0x1014_42b2, 0x17)) goto l_0x1014_42b2; /* jnz 0x101442b2 */
            ii(0x1014_429b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_429e, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1014_42a1, 5); call(/* sys */ 0x1016_6990, 0x2_26ea);  /* call 0x10166990 */
            ii(0x1014_42a6, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1014_42ad, 5); jmp(0x1014_445a, 0x1a8); goto l_0x1014_445a; /* jmp 0x1014445a */
        l_0x1014_42b2:
            ii(0x1014_42b2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_42b5, 3); add(eax, 0x52);                         /* add eax, 0x52 */
            ii(0x1014_42b8, 1); push(eax);                              /* push eax */
            ii(0x1014_42b9, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1014_42be, 1); push(eax);                              /* push eax */
            ii(0x1014_42bf, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1014_42c4, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1014_42c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_42cb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_42cd, 5); call(0x100e_a5fb, -0x5_9cd7);           /* call 0x100ea5fb */
            ii(0x1014_42d2, 5); mov(eax, 0x1_4288);                     /* mov eax, 0x14288 */
            ii(0x1014_42d7, 5); call(Definitions.sys_malloc, 0x2_6d02); /* call 0x1016afde */
            ii(0x1014_42dc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_42de, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_42e1, 3); mov(memd[ds, eax + 0x1e], edx);         /* mov [eax+0x1e], edx */
            ii(0x1014_42e4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_42e7, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_42ea, 5); mov(memw[ds, eax], 0xf0);               /* mov word [eax], 0xf0 */
            ii(0x1014_42ef, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_42f2, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_42f5, 6); mov(memw[ds, eax + 0x2], 0x158);        /* mov word [eax+0x2], 0x158 */
            ii(0x1014_42fb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_42fe, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_4301, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1014_4304, 1); push(eax);                              /* push eax */
            ii(0x1014_4305, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4308, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_430b, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1014_430e, 1); push(eax);                              /* push eax */
            ii(0x1014_430f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4312, 3); push(memd[ds, eax + 0x1a]);             /* push dword [eax+0x1a] */
            ii(0x1014_4315, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4318, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_431b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_431d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_4320, 1); push(eax);                              /* push eax */
            ii(0x1014_4321, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4324, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1014_4327, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1014_432a, 1); push(eax);                              /* push eax */
            ii(0x1014_432b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_432e, 3); mov(edx, memd[ds, eax + 0x16]);         /* mov edx, [eax+0x16] */
            ii(0x1014_4331, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4334, 4); imul(eax, memd[ds, eax + 0x1a], 0x46);  /* imul eax, [eax+0x1a], 0x46 */
            ii(0x1014_4338, 6); add(edx, 0xae);                         /* add edx, 0xae */
            ii(0x1014_433e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_4340, 1); push(eax);                              /* push eax */
            ii(0x1014_4341, 5); call(/* sys */ 0x1016_abbc, 0x2_6876);  /* call 0x1016abbc */
            ii(0x1014_4346, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1014_4349, 7); mov(memd[ss, ebp - 0xc], 0xa);          /* mov dword [ebp-0xc], 0xa */
        l_0x1014_4350:
            ii(0x1014_4350, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1014_4353, 5); cmp(memw[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1014_4358, 2); if(jz(0x1014_43c4, 0x6a)) goto l_0x1014_43c4; /* jz 0x101443c4 */
            ii(0x1014_435a, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1014_435e, 3); imul(edx, eax, 0x14);                   /* imul edx, eax, 0x14 */
            ii(0x1014_4361, 5); mov(eax, 0x101b_d814);                  /* mov eax, 0x101bd814 */
            ii(0x1014_4366, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_4368, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_436b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_4370, 1); push(eax);                              /* push eax */
            ii(0x1014_4371, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_4376, 1); push(eax);                              /* push eax */
            ii(0x1014_4377, 2); push(0x2);                              /* push 0x2 */
            ii(0x1014_4379, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_437c, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1014_4380, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1014_4383, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x1014_4387, 1); cwde();                                 /* cwde */
            ii(0x1014_4388, 1); push(eax);                              /* push eax */
            ii(0x1014_4389, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_438c, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1014_4390, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1014_4393, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1014_4396, 1); cwde();                                 /* cwde */
            ii(0x1014_4397, 1); push(eax);                              /* push eax */
            ii(0x1014_4398, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_439b, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1014_439e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_43a1, 1); push(eax);                              /* push eax */
            ii(0x1014_43a2, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_43a5, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1014_43a8, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_43ab, 3); mov(ebx, memd[ds, eax + 0x10]);         /* mov ebx, [eax+0x10] */
            ii(0x1014_43ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_43b1, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1014_43b4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_43b7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_43ba, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1014_43bd, 5); call(0x100e_9ae5, -0x5_a8dd);           /* call 0x100e9ae5 */
            ii(0x1014_43c2, 2); jmp(0x1014_4350, -0x74); goto l_0x1014_4350; /* jmp 0x10144350 */
        l_0x1014_43c4:
            ii(0x1014_43c4, 7); mov(memd[ss, ebp - 0xc], 0xb);          /* mov dword [ebp-0xc], 0xb */
        l_0x1014_43cb:
            ii(0x1014_43cb, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1014_43ce, 5); cmp(memw[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1014_43d3, 2); if(jz(0x1014_43e3, 0xe)) goto l_0x1014_43e3; /* jz 0x101443e3 */
            ii(0x1014_43d5, 4); movsx(edx, memb[ss, ebp - 0xc]);        /* movsx edx, byte [ebp-0xc] */
            ii(0x1014_43d9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_43dc, 5); call(0x1014_3fac, -0x435);              /* call 0x10143fac */
            ii(0x1014_43e1, 2); jmp(0x1014_43cb, -0x18); goto l_0x1014_43cb; /* jmp 0x101443cb */
        l_0x1014_43e3:
            ii(0x1014_43e3, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_43e6, 6); add(ebx, 0x16a);                        /* add ebx, 0x16a */
            ii(0x1014_43ec, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_43ef, 6); add(edx, 0x152);                        /* add edx, 0x152 */
            ii(0x1014_43f5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_43f8, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_43fb, 5); call(0x1007_68e0, -0xc_db20);           /* call 0x100768e0 */
            ii(0x1014_4400, 5); call(0x1014_3319, -0x10ec);             /* call 0x10143319 */
            ii(0x1014_4405, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_4408, 6); add(edx, 0x176);                        /* add edx, 0x176 */
            ii(0x1014_440e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4411, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4414, 5); call(0x1007_68e0, -0xc_db39);           /* call 0x100768e0 */
            ii(0x1014_4419, 5); call(0x1014_34d4, -0xf4a);              /* call 0x101434d4 */
            ii(0x1014_441e, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4421, 6); add(ebx, 0x18e);                        /* add ebx, 0x18e */
            ii(0x1014_4427, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_442a, 6); add(edx, 0x182);                        /* add edx, 0x182 */
            ii(0x1014_4430, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4433, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4436, 5); call(0x1007_68e0, -0xc_db5b);           /* call 0x100768e0 */
            ii(0x1014_443b, 5); call(0x1014_3616, -0xe2a);              /* call 0x10143616 */
            ii(0x1014_4440, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4443, 5); call(0x1014_3d54, -0x6f4);              /* call 0x10143d54 */
            ii(0x1014_4448, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_444b, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1014_444e, 5); call(Definitions.sys_display_draw_0, 0x2_3031); /* call 0x10167484 */
            ii(0x1014_4453, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
        l_0x1014_445a:
            ii(0x1014_445a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_445d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_445f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_4460, 1); pop(edi);                               /* pop edi */
            ii(0x1014_4461, 1); pop(esi);                               /* pop esi */
            ii(0x1014_4462, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_4463, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_4464, 1); ret();                                  /* ret */
        }
    }
}
