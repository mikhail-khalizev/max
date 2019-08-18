using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b10af1df-02e5-4c9c-bccd-42cc0f8f5122")]
        public void Method_100a_83ea()
        {
            ii(0x100a_83ea, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_83ef, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d95e); /* call 0x10165d52 */
            ii(0x100a_83f4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_83f5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_83f6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_83f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_83f9, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_83ff, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_8402, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_8405, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_8408, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_840b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_840e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_8411, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_8415, 2); if(jzd(0x100a_8441, 0x2a)) goto l_0x100a_8441; /* jz 0x100a8441 */
            ii(0x100a_8417, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8419, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_841c, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_841f, 5); calld(0x1013_ad71, 0x9_294d);           /* call 0x1013ad71 */
            ii(0x100a_8424, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8426, 2); if(jzd(0x100a_843f, 0x17)) goto l_0x100a_843f; /* jz 0x100a843f */
            ii(0x100a_8428, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100a_842b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_842e, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8431, 5); calld(0x1007_6574, -0x3_1ec2);          /* call 0x10076574 */
            ii(0x100a_8436, 5); calld(0x1015_2a52, 0xa_a617);           /* call 0x10152a52 */
            ii(0x100a_843b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_843d, 2); if(jzd(0x100a_8441, 0x2)) goto l_0x100a_8441; /* jz 0x100a8441 */
        l_0x100a_843f:
            ii(0x100a_843f, 2); jmpd(0x100a_8443, 0x2); goto l_0x100a_8443; /* jmp 0x100a8443 */
        l_0x100a_8441:
            ii(0x100a_8441, 2); jmpd(0x100a_8468, 0x25); goto l_0x100a_8468; /* jmp 0x100a8468 */
        l_0x100a_8443:
            ii(0x100a_8443, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8445, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_844a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_844c, 2); if(jnzd(0x100a_8463, 0x15)) goto l_0x100a_8463; /* jnz 0x100a8463 */
            ii(0x100a_844e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8451, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_8454, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8457, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8459, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100a_845f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_8461, 2); if(jnzd(0x100a_8468, 0x5)) goto l_0x100a_8468; /* jnz 0x100a8468 */
        l_0x100a_8463:
            ii(0x100a_8463, 5); jmpd(0x100a_84f3, 0x8b); goto l_0x100a_84f3; /* jmp 0x100a84f3 */
        l_0x100a_8468:
            ii(0x100a_8468, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_846a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_846d, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8470, 5); calld(0x1013_ad71, 0x9_28fc);           /* call 0x1013ad71 */
            ii(0x100a_8475, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8477, 2); if(jzd(0x100a_84c9, 0x50)) goto l_0x100a_84c9; /* jz 0x100a84c9 */
            ii(0x100a_8479, 5); calld(0x1008_ac50, -0x1_d82e);          /* call 0x1008ac50 */
            ii(0x100a_847e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_8480, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_8482, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100a_8485, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8488, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_848b, 5); calld(0x1007_6574, -0x3_1f1c);          /* call 0x10076574 */
            ii(0x100a_8490, 5); calld(0x1015_2962, 0xa_a4cd);           /* call 0x10152962 */
            ii(0x100a_8495, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8498, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_849b, 5); calld(0x1007_6574, -0x3_1f2c);          /* call 0x10076574 */
            ii(0x100a_84a0, 5); calld(0x1015_26ac, 0xa_a207);           /* call 0x101526ac */
            ii(0x100a_84a5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_84a7, 2); if(jnzd(0x100a_84c9, 0x20)) goto l_0x100a_84c9; /* jnz 0x100a84c9 */
            ii(0x100a_84a9, 5); calld(0x1008_a79c, -0x1_dd12);          /* call 0x1008a79c */
            ii(0x100a_84ae, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_84b0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_84b2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_84b5, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_84b8, 5); calld(0x1007_65d0, -0x3_1eed);          /* call 0x100765d0 */
            ii(0x100a_84bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_84bf, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_84c4, 5); calld(0x100a_53ac, -0x311d);            /* call 0x100a53ac */
        l_0x100a_84c9:
            ii(0x100a_84c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_84cb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_84ce, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_84d1, 5); calld(0x1007_6630, -0x3_1ea6);          /* call 0x10076630 */
            ii(0x100a_84d6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_84d9, 4); mov(memb_a32[ds, eax + 0x13], 0);       /* mov byte [eax+0x13], 0x0 */
            ii(0x100a_84dd, 5); calld(0x100a_b288, 0x2da6);             /* call 0x100ab288 */
            ii(0x100a_84e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_84e4, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_84e6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_84e9, 5); calld(0x100a_28ff, -0x5bef);            /* call 0x100a28ff */
            ii(0x100a_84ee, 5); jmpd(0x100a_85b0, 0xbd); goto l_0x100a_85b0; /* jmp 0x100a85b0 */
        l_0x100a_84f3:
            ii(0x100a_84f3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_84f5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_84f8, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_84fb, 5); calld(0x1013_ad71, 0x9_2871);           /* call 0x1013ad71 */
            ii(0x100a_8500, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8502, 2); if(jzd(0x100a_850d, 0x9)) goto l_0x100a_850d; /* jz 0x100a850d */
            ii(0x100a_8504, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_850b, 2); jmpd(0x100a_8526, 0x19); goto l_0x100a_8526; /* jmp 0x100a8526 */
        l_0x100a_850d:
            ii(0x100a_850d, 5); mov(ecx, 0xd37);                        /* mov ecx, 0xd37 */
            ii(0x100a_8512, 5); mov(ebx, StringDefinitions.AiMainCpp2); /* mov ebx, 0x101a0cc5 */
            ii(0x100a_8517, 5); mov(edx, StringDefinitions.ClearZoneMovingUnitNotEqual0); /* mov edx, 0x101a0cd1 */
            ii(0x100a_851c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_851e, 5); calld(Definitions.sys_assert, 0xb_d86f); /* call 0x10165d92 */
            ii(0x100a_8523, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x100a_8526:
            ii(0x100a_8526, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8529, 4); mov(memb_a32[ds, eax + 0x13], 0x4);     /* mov byte [eax+0x13], 0x4 */
            ii(0x100a_852d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8530, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8533, 5); calld(0x1007_6574, -0x3_1fc4);          /* call 0x10076574 */
            ii(0x100a_8538, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x100a_853c, 2); if(jzd(0x100a_8557, 0x19)) goto l_0x100a_8557; /* jz 0x100a8557 */
            ii(0x100a_853e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_8540, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_8545, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8548, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_854b, 5); calld(0x1007_65d0, -0x3_1f80);          /* call 0x100765d0 */
            ii(0x100a_8550, 5); calld(0x1016_3053, 0xb_aafe);           /* call 0x10163053 */
            ii(0x100a_8555, 2); jmpd(0x100a_85b0, 0x59); goto l_0x100a_85b0; /* jmp 0x100a85b0 */
        l_0x100a_8557:
            ii(0x100a_8557, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_855a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_855d, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8560, 5); calld(0x1007_6574, -0x3_1ff1);          /* call 0x10076574 */
            ii(0x100a_8565, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100a_8568, 5); calld(0x1007_6a34, -0x3_1b39);          /* call 0x10076a34 */
            ii(0x100a_856d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_8570, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8573, 5); calld(0x1007_6574, -0x3_2004);          /* call 0x10076574 */
            ii(0x100a_8578, 5); calld(0x1015_48ba, 0xa_c33d);           /* call 0x101548ba */
            ii(0x100a_857d, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100a_8582, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_8587, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_858a, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_858d, 5); calld(0x1007_65d0, -0x3_1fc2);          /* call 0x100765d0 */
            ii(0x100a_8592, 5); calld(0x1016_3053, 0xb_aabc);           /* call 0x10163053 */
            ii(0x100a_8597, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100a_859e, 2); if(jzd(0x100a_85b0, 0x10)) goto l_0x100a_85b0; /* jz 0x100a85b0 */
            ii(0x100a_85a0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_85a3, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_85a6, 5); calld(0x1007_65d0, -0x3_1fdb);          /* call 0x100765d0 */
            ii(0x100a_85ab, 5); calld(0x1012_ae8d, 0x8_28dd);           /* call 0x1012ae8d */
        l_0x100a_85b0:
            ii(0x100a_85b0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_85b2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_85b3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_85b4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_85b5, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
