using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8ee460c-d1c2-4c51-a3c9-d0a02d32d918")]
        public void Method_1012_c088()
        {
            ii(0x1012_c088, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1012_c08d, 5); calld(Definitions.sys_check_available_stack_size, 0x3_9cc0); /* call 0x10165d52 */
            ii(0x1012_c092, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_c093, 1); pushd(esi);                             /* push esi */
            ii(0x1012_c094, 1); pushd(edi);                             /* push edi */
            ii(0x1012_c095, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_c096, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_c098, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1012_c09e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_c0a1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_c0a4, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_c0a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c0aa, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c0ad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c0b0, 5); calld(0x1007_1ff5, -0xb_a0c0);          /* call 0x10071ff5 */
            ii(0x1012_c0b5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_c0b8, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c0bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c0be, 2); if(jzd(0x1012_c0d3, 0x13)) goto l_0x1012_c0d3; /* jz 0x1012c0d3 */
            ii(0x1012_c0c0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c0c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c0c5, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_c0c8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c0ca, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_c0cf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_c0d1, 2); if(jzd(0x1012_c0d8, 0x5)) goto l_0x1012_c0d8; /* jz 0x1012c0d8 */
        l_0x1012_c0d3:
            ii(0x1012_c0d3, 5); jmpd(0x1012_c2fb, 0x223); goto l_0x1012_c2fb; /* jmp 0x1012c2fb */
        l_0x1012_c0d8:
            ii(0x1012_c0d8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_c0db, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_c0de, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_c0e5, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1012_c0ec, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1012_c0ef, 5); calld(0x1007_20b1, -0xb_a043);          /* call 0x100720b1 */
            ii(0x1012_c0f4, 5); calld(0x1007_6014, -0xb_60e5);          /* call 0x10076014 */
            ii(0x1012_c0f9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_c0fb, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_c0fd, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1012_c100, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c103, 5); calld(0x1007_2388, -0xb_9d80);          /* call 0x10072388 */
            ii(0x1012_c108, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_c10b, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_c10e, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c112, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c114, 2); if(jged(0x1012_c14e, 0x38)) goto l_0x1012_c14e; /* jge 0x1012c14e */
            ii(0x1012_c116, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c118, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c119, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c11e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c11f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_c122, 2); neg(eax);                               /* neg eax */
            ii(0x1012_c124, 1); cwde();                                 /* cwde */
            ii(0x1012_c125, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c126, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_c12a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c12b, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c130, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c131, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c136, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c137, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_c13c, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c13f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c142, 5); mov(eax, StringDefinitions.Teams2);     /* mov eax, 0x101a86fb */
            ii(0x1012_c147, 5); calld(0x1012_bd39, -0x413);             /* call 0x1012bd39 */
            ii(0x1012_c14c, 2); jmpd(0x1012_c184, 0x36); goto l_0x1012_c184; /* jmp 0x1012c184 */
        l_0x1012_c14e:
            ii(0x1012_c14e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c150, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c151, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c156, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c157, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c15b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c15c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_c15f, 2); neg(eax);                               /* neg eax */
            ii(0x1012_c161, 1); cwde();                                 /* cwde */
            ii(0x1012_c162, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c163, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c168, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c169, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c16e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c16f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_c174, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c177, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c17a, 5); mov(eax, StringDefinitions.Usage9);     /* mov eax, 0x101a8701 */
            ii(0x1012_c17f, 5); calld(0x1012_bd39, -0x44b);             /* call 0x1012bd39 */
        l_0x1012_c184:
            ii(0x1012_c184, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_c18b, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_c192, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1012_c197, 5); calld(0x1007_6338, -0xb_5e64);          /* call 0x10076338 */
            ii(0x1012_c19c, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x1012_c19f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_c1a1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_c1a3, 5); calld(0x1007_64b8, -0xb_5cf0);          /* call 0x100764b8 */
            ii(0x1012_c1a8, 2); jmpd(0x1012_c1b2, 0x8); goto l_0x1012_c1b2; /* jmp 0x1012c1b2 */
        l_0x1012_c1aa:
            ii(0x1012_c1aa, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1012_c1ad, 5); calld(0x1007_6bf8, -0xb_55ba);          /* call 0x10076bf8 */
        l_0x1012_c1b2:
            ii(0x1012_c1b2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c1b4, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1012_c1b7, 5); calld(0x1013_ad71, 0xebb5);             /* call 0x1013ad71 */
            ii(0x1012_c1bc, 2); test(al, al);                           /* test al, al */
            ii(0x1012_c1be, 6); if(jzd(0x1012_c240, 0x7c)) goto l_0x1012_c240; /* jz 0x1012c240 */
            ii(0x1012_c1c4, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1012_c1c7, 5); calld(0x1007_63a0, -0xb_5e2c);          /* call 0x100763a0 */
            ii(0x1012_c1cc, 5); calld(0x1007_6204, -0xb_5fcd);          /* call 0x10076204 */
            ii(0x1012_c1d1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_c1d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c1d6, 5); calld(0x1007_6204, -0xb_5fd7);          /* call 0x10076204 */
            ii(0x1012_c1db, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_c1dd, 2); if(jnzd(0x1012_c23b, 0x5c)) goto l_0x1012_c23b; /* jnz 0x1012c23b */
            ii(0x1012_c1df, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1012_c1e2, 5); calld(0x1007_63a0, -0xb_5e47);          /* call 0x100763a0 */
            ii(0x1012_c1e7, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c1ea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c1ed, 5); calld(0x1007_1ff5, -0xb_a1fd);          /* call 0x10071ff5 */
            ii(0x1012_c1f2, 4); mov(memw_a32[ss, ebp - 0x20], ax);      /* mov [ebp-0x20], ax */
            ii(0x1012_c1f6, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_c1fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c1fc, 2); if(jged(0x1012_c206, 0x8)) goto l_0x1012_c206; /* jge 0x1012c206 */
            ii(0x1012_c1fe, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_c201, 3); sub(memd_a32[ss, ebp - 0x10], eax);     /* sub [ebp-0x10], eax */
            ii(0x1012_c204, 2); jmpd(0x1012_c20c, 0x6); goto l_0x1012_c20c; /* jmp 0x1012c20c */
        l_0x1012_c206:
            ii(0x1012_c206, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_c209, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1012_c20c:
            ii(0x1012_c20c, 5); calld(0x1007_6014, -0xb_61fd);          /* call 0x10076014 */
            ii(0x1012_c211, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_c213, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_c215, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1012_c218, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1012_c21b, 5); calld(0x1007_63d4, -0xb_5e4c);          /* call 0x100763d4 */
            ii(0x1012_c220, 5); calld(0x1007_2388, -0xb_9e9d);          /* call 0x10072388 */
            ii(0x1012_c225, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1012_c229, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c22b, 2); if(jged(0x1012_c235, 0x8)) goto l_0x1012_c235; /* jge 0x1012c235 */
            ii(0x1012_c22d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_c230, 3); sub(memd_a32[ss, ebp - 0x1c], eax);     /* sub [ebp-0x1c], eax */
            ii(0x1012_c233, 2); jmpd(0x1012_c23b, 0x6); goto l_0x1012_c23b; /* jmp 0x1012c23b */
        l_0x1012_c235:
            ii(0x1012_c235, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_c238, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x1012_c23b:
            ii(0x1012_c23b, 5); jmpd(0x1012_c1aa, -0x96); goto l_0x1012_c1aa; /* jmp 0x1012c1aa */
        l_0x1012_c240:
            ii(0x1012_c240, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c243, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c246, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c249, 5); calld(0x1007_1ff5, -0xb_a259);          /* call 0x10071ff5 */
            ii(0x1012_c24e, 1); cwde();                                 /* cwde */
            ii(0x1012_c24f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c251, 2); if(jled(0x1012_c289, 0x36)) goto l_0x1012_c289; /* jle 0x1012c289 */
            ii(0x1012_c253, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c255, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c256, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c25b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c25c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_c260, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c261, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_c265, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c266, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c26b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c26c, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c271, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c272, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1012_c277, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c27a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c27d, 5); mov(eax, StringDefinitions.Usage7);     /* mov eax, 0x101a8707 */
            ii(0x1012_c282, 5); calld(0x1012_bd39, -0x54e);             /* call 0x1012bd39 */
            ii(0x1012_c287, 2); jmpd(0x1012_c2f1, 0x68); goto l_0x1012_c2f1; /* jmp 0x1012c2f1 */
        l_0x1012_c289:
            ii(0x1012_c289, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c28b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c28c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c291, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c292, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c296, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c297, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_c29b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c29c, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c2a1, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2a2, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c2a7, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2a8, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1012_c2ad, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c2b0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c2b3, 5); mov(eax, StringDefinitions.Total11);    /* mov eax, 0x101a870d */
            ii(0x1012_c2b8, 5); calld(0x1012_bd39, -0x584);             /* call 0x1012bd39 */
            ii(0x1012_c2bd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c2bf, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2c0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c2c5, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2c6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_c2ca, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2cb, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_c2cf, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2d0, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c2d5, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2d6, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c2db, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c2dc, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1012_c2e1, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c2e4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c2e7, 5); mov(eax, StringDefinitions.Usage8);     /* mov eax, 0x101a8713 */
            ii(0x1012_c2ec, 5); calld(0x1012_bd39, -0x5b8);             /* call 0x1012bd39 */
        l_0x1012_c2f1:
            ii(0x1012_c2f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c2f3, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1012_c2f6, 5); calld(0x1007_5f6c, -0xb_638f);          /* call 0x10075f6c */
        l_0x1012_c2fb:
            ii(0x1012_c2fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_c2fd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_c2fe, 1); popd(edi);                              /* pop edi */
            ii(0x1012_c2ff, 1); popd(esi);                              /* pop esi */
            ii(0x1012_c300, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_c301, 1); retd(); return;                         /* ret */
        }
    }
}
