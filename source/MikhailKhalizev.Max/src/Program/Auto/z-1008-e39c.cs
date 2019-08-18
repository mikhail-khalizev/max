using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ee625ae7-ff12-43bb-96c9-560087618d4e")]
        public void Method_1008_e39c()
        {
            ii(0x1008_e39c, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x1008_e3a1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_79ac); /* call 0x10165d52 */
            ii(0x1008_e3a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_e3a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_e3a8, 1); pushd(edx);                             /* push edx */
            ii(0x1008_e3a9, 1); pushd(esi);                             /* push esi */
            ii(0x1008_e3aa, 1); pushd(edi);                             /* push edi */
            ii(0x1008_e3ab, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_e3ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_e3ae, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1008_e3b4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_e3b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_e3ba, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_e3bd, 5); calld(0x1007_6b90, -0x1_7832);          /* call 0x10076b90 */
            ii(0x1008_e3c2, 1); cwde();                                 /* cwde */
            ii(0x1008_e3c3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_e3c5, 2); if(jzd(0x1008_e3d0, 0x9)) goto l_0x1008_e3d0; /* jz 0x1008e3d0 */
            ii(0x1008_e3c7, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_e3cb, 5); jmpd(0x1008_e54e, 0x17e); goto l_0x1008_e54e; /* jmp 0x1008e54e */
        l_0x1008_e3d0:
            ii(0x1008_e3d0, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_e3d4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e3d7, 5); calld(0x1007_64fc, -0x1_7ee0);          /* call 0x100764fc */
            ii(0x1008_e3dc, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_e3df, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_e3e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_e3e6, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_e3e9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_e3ec, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_e3ef, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1008_e3f2, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_e3f5, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1008_e3f8, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_e3fb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_e3fe, 2); jmpd(0x1008_e406, 0x6); goto l_0x1008_e406; /* jmp 0x1008e406 */
        l_0x1008_e400:
            ii(0x1008_e400, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_e403, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1008_e406:
            ii(0x1008_e406, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1008_e40a, 3); cmp(eax, memd_a32[ss, ebp - 0x28]);     /* cmp eax, [ebp-0x28] */
            ii(0x1008_e40d, 6); if(jged(0x1008_e534, 0x121)) goto l_0x1008_e534; /* jge 0x1008e534 */
            ii(0x1008_e413, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_e416, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_e419, 2); jmpd(0x1008_e421, 0x6); goto l_0x1008_e421; /* jmp 0x1008e421 */
        l_0x1008_e41b:
            ii(0x1008_e41b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_e41e, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1008_e421:
            ii(0x1008_e421, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e425, 3); cmp(eax, memd_a32[ss, ebp - 0x24]);     /* cmp eax, [ebp-0x24] */
            ii(0x1008_e428, 6); if(jged(0x1008_e52f, 0x101)) goto l_0x1008_e52f; /* jge 0x1008e52f */
            ii(0x1008_e42e, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1008_e432, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1008_e436, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1008_e43b, 5); calld(0x1010_3541, 0x7_5101);           /* call 0x10103541 */
            ii(0x1008_e440, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e442, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e445, 5); calld(0x1007_643c, -0x1_800e);          /* call 0x1007643c */
            ii(0x1008_e44a, 2); jmpd(0x1008_e454, 0x8); goto l_0x1008_e454; /* jmp 0x1008e454 */
        l_0x1008_e44c:
            ii(0x1008_e44c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e44f, 5); calld(0x1007_6bf8, -0x1_785c);          /* call 0x10076bf8 */
        l_0x1008_e454:
            ii(0x1008_e454, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e456, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e459, 5); calld(0x1013_ad71, 0xa_c913);           /* call 0x1013ad71 */
            ii(0x1008_e45e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e460, 2); if(jzd(0x1008_e484, 0x22)) goto l_0x1008_e484; /* jz 0x1008e484 */
            ii(0x1008_e462, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e465, 5); calld(0x1007_63a0, -0x1_80ca);          /* call 0x100763a0 */
            ii(0x1008_e46a, 5); cmp(memw_a32[ds, eax + 0x8], 0xe);      /* cmp word [eax+0x8], 0xe */
            ii(0x1008_e46f, 2); if(jzd(0x1008_e480, 0xf)) goto l_0x1008_e480; /* jz 0x1008e480 */
            ii(0x1008_e471, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e474, 5); calld(0x1007_63a0, -0x1_80d9);          /* call 0x100763a0 */
            ii(0x1008_e479, 5); cmp(memw_a32[ds, eax + 0x8], 0xd);      /* cmp word [eax+0x8], 0xd */
            ii(0x1008_e47e, 2); if(jnzd(0x1008_e482, 0x2)) goto l_0x1008_e482; /* jnz 0x1008e482 */
        l_0x1008_e480:
            ii(0x1008_e480, 2); jmpd(0x1008_e484, 0x2); goto l_0x1008_e484; /* jmp 0x1008e484 */
        l_0x1008_e482:
            ii(0x1008_e482, 2); jmpd(0x1008_e44c, -0x38); goto l_0x1008_e44c; /* jmp 0x1008e44c */
        l_0x1008_e484:
            ii(0x1008_e484, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e486, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e489, 5); calld(0x1013_ad71, 0xa_c8e3);           /* call 0x1013ad71 */
            ii(0x1008_e48e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e490, 6); if(jzd(0x1008_e52a, 0x94)) goto l_0x1008_e52a; /* jz 0x1008e52a */
            ii(0x1008_e496, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1008_e49b, 5); calld(Definitions.sys_new, 0xd_7960);   /* call 0x10165e00 */
            ii(0x1008_e4a0, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1008_e4a3, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1008_e4a6, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_e4a9, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1008_e4ad, 2); if(jzd(0x1008_e4d4, 0x25)) goto l_0x1008_e4d4; /* jz 0x1008e4d4 */
            ii(0x1008_e4af, 5); mov(ecx, 0x200);                        /* mov ecx, 0x200 */
            ii(0x1008_e4b4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e4b7, 5); calld(0x1007_63d4, -0x1_80e8);          /* call 0x100763d4 */
            ii(0x1008_e4bc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_e4be, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_e4c1, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1008_e4c4, 5); calld(0x1009_a085, 0xbbbc);             /* call 0x1009a085 */
            ii(0x1008_e4c9, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1008_e4cc, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1008_e4cf, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1008_e4d2, 2); jmpd(0x1008_e4da, 0x6); goto l_0x1008_e4da; /* jmp 0x1008e4da */
        l_0x1008_e4d4:
            ii(0x1008_e4d4, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1008_e4d7, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x1008_e4da:
            ii(0x1008_e4da, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x1008_e4dd, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_e4e0, 5); calld(0x1008_b060, -0x3485);            /* call 0x1008b060 */
            ii(0x1008_e4e5, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_e4e8, 5); calld(0x1008_af84, -0x3569);            /* call 0x1008af84 */
            ii(0x1008_e4ed, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1008_e4f0, 3); add(ebx, 0x2b);                         /* add ebx, 0x2b */
            ii(0x1008_e4f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e4f5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_e4f7, 5); calld(0x1009_ca40, 0xe544);             /* call 0x1009ca40 */
            ii(0x1008_e4fc, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_e4ff, 5); calld(0x1008_af84, -0x3580);            /* call 0x1008af84 */
            ii(0x1008_e504, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e506, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_e50b, 5); calld(0x100a_4d50, 0x1_6840);           /* call 0x100a4d50 */
            ii(0x1008_e510, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_e514, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e516, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_e519, 5); calld(0x1008_8b7c, -0x59a2);            /* call 0x10088b7c */
            ii(0x1008_e51e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e520, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e523, 5); calld(0x1007_5f6c, -0x1_85bc);          /* call 0x10075f6c */
            ii(0x1008_e528, 2); jmpd(0x1008_e54e, 0x24); goto l_0x1008_e54e; /* jmp 0x1008e54e */
        l_0x1008_e52a:
            ii(0x1008_e52a, 5); jmpd(0x1008_e41b, -0x114); goto l_0x1008_e41b; /* jmp 0x1008e41b */
        l_0x1008_e52f:
            ii(0x1008_e52f, 5); jmpd(0x1008_e400, -0x134); goto l_0x1008_e400; /* jmp 0x1008e400 */
        l_0x1008_e534:
            ii(0x1008_e534, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_e538, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e53a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_e53d, 5); calld(0x1007_5f6c, -0x1_85d6);          /* call 0x10075f6c */
            ii(0x1008_e542, 2); jmpd(0x1008_e54e, 0xa); goto l_0x1008_e54e; /* jmp 0x1008e54e */
        //    ii(0x1008_e544, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1008_e546, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
        //    ii(0x1008_e549, 5); calld(0x1007_5f6c, -0x1_85e2);          /* call 0x10075f6c */
        l_0x1008_e54e:
            ii(0x1008_e54e, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_e551, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_e553, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_e554, 1); popd(edi);                              /* pop edi */
            ii(0x1008_e555, 1); popd(esi);                              /* pop esi */
            ii(0x1008_e556, 1); popd(edx);                              /* pop edx */
            ii(0x1008_e557, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_e558, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_e559, 1); retd(); return;                         /* ret */
        }
    }
}
