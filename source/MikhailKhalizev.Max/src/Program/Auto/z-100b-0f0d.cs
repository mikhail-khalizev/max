using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0f0d-bdb8933f")]
        public void Method_100b_0f0d()
        {
            ii(0x100b_0f0d, 5); push(0x40);                             /* push 0x40 */
            ii(0x100b_0f12, 5); call(Definitions.sys_check_available_stack_size, 0xb_4e3b); /* call 0x10165d52 */
            ii(0x100b_0f17, 1); push(ebx);                              /* push ebx */
            ii(0x100b_0f18, 1); push(ecx);                              /* push ecx */
            ii(0x100b_0f19, 1); push(esi);                              /* push esi */
            ii(0x100b_0f1a, 1); push(edi);                              /* push edi */
            ii(0x100b_0f1b, 1); push(ebp);                              /* push ebp */
            ii(0x100b_0f1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0f1e, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_0f24, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_0f27, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_0f2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0f2c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_0f2f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0f32, 5); call(0x1013_ad11, 0x8_9dda);            /* call 0x1013ad11 */
            ii(0x100b_0f37, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0f39, 2); if(jnz(0x100b_0f50, 0x15)) goto l_0x100b_0f50; /* jnz 0x100b0f50 */
            ii(0x100b_0f3b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_0f3e, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0f41, 5); call(0x1007_6574, -0x3_a9d2);           /* call 0x10076574 */
            ii(0x100b_0f46, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100b_0f49, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0f4c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0f4e, 2); if(jnz(0x100b_0f55, 5)) goto l_0x100b_0f55; /* jnz 0x100b0f55 */
        l_0x100b_0f50:
            ii(0x100b_0f50, 5); jmp(0x100b_10e0, 0x18b); goto l_0x100b_10e0; /* jmp 0x100b10e0 */
        l_0x100b_0f55:
            ii(0x100b_0f55, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_0f5a, 5); call(0x1007_6338, -0x3_ac27);           /* call 0x10076338 */
            ii(0x100b_0f5f, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x100b_0f62, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_0f64, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_0f66, 5); call(0x1007_64b8, -0x3_aab3);           /* call 0x100764b8 */
            ii(0x100b_0f6b, 2); jmp(0x100b_0f75, 8); goto l_0x100b_0f75; /* jmp 0x100b0f75 */
        l_0x100b_0f6d:
            ii(0x100b_0f6d, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0f70, 5); call(0x1007_6bf8, -0x3_a37d);           /* call 0x10076bf8 */
        l_0x100b_0f75:
            ii(0x100b_0f75, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0f77, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0f7a, 5); call(0x1013_ad71, 0x8_9df2);            /* call 0x1013ad71 */
            ii(0x100b_0f7f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0f81, 6); if(jz(0x100b_10d6, 0x14f)) goto l_0x100b_10d6; /* jz 0x100b10d6 */
            ii(0x100b_0f87, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0f8a, 5); call(0x1007_63a0, -0x3_abef);           /* call 0x100763a0 */
            ii(0x100b_0f8f, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_0f93, 2); if(jnz(0x100b_0fb1, 0x1c)) goto l_0x100b_0fb1; /* jnz 0x100b0fb1 */
            ii(0x100b_0f95, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_0f98, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x100b_0f9b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0f9e, 5); call(0x1007_63a0, -0x3_ac03);           /* call 0x100763a0 */
            ii(0x100b_0fa3, 5); call(0x1007_611c, -0x3_ae8c);           /* call 0x1007611c */
            ii(0x100b_0fa8, 5); call(0x1007_6d98, -0x3_a215);           /* call 0x10076d98 */
            ii(0x100b_0fad, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0faf, 2); if(jnz(0x100b_0fb3, 2)) goto l_0x100b_0fb3; /* jnz 0x100b0fb3 */
        l_0x100b_0fb1:
            ii(0x100b_0fb1, 2); jmp(0x100b_0fcd, 0x1a); goto l_0x100b_0fcd; /* jmp 0x100b0fcd */
        l_0x100b_0fb3:
            ii(0x100b_0fb3, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0fb6, 5); call(0x1007_63a0, -0x3_ac1b);           /* call 0x100763a0 */
            ii(0x100b_0fbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0fbd, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100b_0fc0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_0fc3, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100b_0fc6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0fc9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_0fcb, 2); if(jz(0x100b_0fd2, 5)) goto l_0x100b_0fd2; /* jz 0x100b0fd2 */
        l_0x100b_0fcd:
            ii(0x100b_0fcd, 5); jmp(0x100b_10d1, 0xff); goto l_0x100b_10d1; /* jmp 0x100b10d1 */
        l_0x100b_0fd2:
            ii(0x100b_0fd2, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0fd5, 5); call(0x1007_63a0, -0x3_ac3a);           /* call 0x100763a0 */
            ii(0x100b_0fda, 5); call(0x1015_26ac, 0xa_16cd);            /* call 0x101526ac */
            ii(0x100b_0fdf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0fe1, 2); if(jz(0x100b_1003, 0x20)) goto l_0x100b_1003; /* jz 0x100b1003 */
            ii(0x100b_0fe3, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_0fe6, 5); call(0x1007_63a0, -0x3_ac4b);           /* call 0x100763a0 */
            ii(0x100b_0feb, 5); call(0x1015_26ac, 0xa_16bc);            /* call 0x101526ac */
            ii(0x100b_0ff0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_0ff3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_0ff6, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_0ff9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_0ffc, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_0fff, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_1001, 2); if(jz(0x100b_1051, 0x4e)) goto l_0x100b_1051; /* jz 0x100b1051 */
        l_0x100b_1003:
            ii(0x100b_1003, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_1008, 5); call(Definitions.sys_new, 0xb_4df3);    /* call 0x10165e00 */
            ii(0x100b_100d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_1010, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_1013, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_1016, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100b_101a, 2); if(jz(0x100b_103e, 0x22)) goto l_0x100b_103e; /* jz 0x100b103e */
            ii(0x100b_101c, 5); mov(ebx, 0x100b_0ebb);                  /* mov ebx, 0x100b0ebb */
            ii(0x100b_1021, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_1024, 5); call(0x1007_63d4, -0x3_ac55);           /* call 0x100763d4 */
            ii(0x100b_1029, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_102b, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_102e, 5); call(0x100a_c45d, -0x4bd6);             /* call 0x100ac45d */
            ii(0x100b_1033, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_1036, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_1039, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_103c, 2); jmp(0x100b_1044, 6); goto l_0x100b_1044; /* jmp 0x100b1044 */
        l_0x100b_103e:
            ii(0x100b_103e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_1041, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100b_1044:
            ii(0x100b_1044, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100b_1047, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_104c, 5); call(0x100a_4d50, -0xc301);             /* call 0x100a4d50 */
        l_0x100b_1051:
            ii(0x100b_1051, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_1054, 5); call(0x1007_63a0, -0x3_acb9);           /* call 0x100763a0 */
            ii(0x100b_1059, 5); call(0x1015_26ac, 0xa_164e);            /* call 0x101526ac */
            ii(0x100b_105e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_1061, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_1064, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_1067, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_106a, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_106d, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_106f, 2); if(jnz(0x100b_107a, 9)) goto l_0x100b_107a; /* jnz 0x100b107a */
            ii(0x100b_1071, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_1078, 2); jmp(0x100b_1093, 0x19); goto l_0x100b_1093; /* jmp 0x100b1093 */
        l_0x100b_107a:
            ii(0x100b_107a, 5); mov(ecx, 0x885);                        /* mov ecx, 0x885 */
            ii(0x100b_107f, 5); mov(ebx, StringDefinitions.AiMoveCpp4); /* mov ebx, 0x101a0fee */
            ii(0x100b_1084, 5); mov(edx, StringDefinitions.UnitGettaskGettypeEqualTaskMove); /* mov edx, 0x101a0ffa */
            ii(0x100b_1089, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_108b, 5); call(Definitions.sys_assert, 0xb_4d02); /* call 0x10165d92 */
            ii(0x100b_1090, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100b_1093:
            ii(0x100b_1093, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_1096, 5); call(0x1007_63a0, -0x3_acfb);           /* call 0x100763a0 */
            ii(0x100b_109b, 5); call(0x1015_26ac, 0xa_160c);            /* call 0x101526ac */
            ii(0x100b_10a0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_10a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_10a5, 5); call(0x100b_7c14, 0x6b6a);              /* call 0x100b7c14 */
            ii(0x100b_10aa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_10ad, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_10b0, 5); call(0x1007_6574, -0x3_ab41);           /* call 0x10076574 */
            ii(0x100b_10b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_10b7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_10ba, 5); call(0x1007_6b90, -0x3_a52f);           /* call 0x10076b90 */
            ii(0x100b_10bf, 4); cmp(ax, memw[ds, edx + 0x52]);          /* cmp ax, [edx+0x52] */
            ii(0x100b_10c3, 2); if(jnz(0x100b_10d1, 0xc)) goto l_0x100b_10d1; /* jnz 0x100b10d1 */
            ii(0x100b_10c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_10c7, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_10ca, 5); call(0x1007_5f6c, -0x3_b163);           /* call 0x10075f6c */
            ii(0x100b_10cf, 2); jmp(0x100b_10e0, 0xf); goto l_0x100b_10e0; /* jmp 0x100b10e0 */
        l_0x100b_10d1:
            ii(0x100b_10d1, 5); jmp(0x100b_0f6d, -0x169); goto l_0x100b_0f6d; /* jmp 0x100b0f6d */
        l_0x100b_10d6:
            ii(0x100b_10d6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_10d8, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_10db, 5); call(0x1007_5f6c, -0x3_b174);           /* call 0x10075f6c */
        l_0x100b_10e0:
            ii(0x100b_10e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_10e2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_10e3, 1); pop(edi);                               /* pop edi */
            ii(0x100b_10e4, 1); pop(esi);                               /* pop esi */
            ii(0x100b_10e5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_10e6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_10e7, 1); ret();                                  /* ret */
        }
    }
}
