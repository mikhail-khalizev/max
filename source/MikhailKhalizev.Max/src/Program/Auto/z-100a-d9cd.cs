using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d9cd-e93b74c4")]
        public void Method_100a_d9cd()
        {
            ii(0x100a_d9cd, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_d9d2, 5); calld(Definitions.sys_check_available_stack_size, 0xb_837b); /* call 0x10165d52 */
            ii(0x100a_d9d7, 1); pushd(esi);                             /* push esi */
            ii(0x100a_d9d8, 1); pushd(edi);                             /* push edi */
            ii(0x100a_d9d9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_d9da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d9dc, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_d9e2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_d9e5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_d9e8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_d9eb, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_d9ee, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_d9f1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d9f4, 5); calld(0x1008_a5f0, -0x2_3409);          /* call 0x1008a5f0 */
            ii(0x100a_d9f9, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_d9fd, 6); if(jnzd(0x100a_da94, 0x91)) goto l_0x100a_da94; /* jnz 0x100ada94 */
            ii(0x100a_da03, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_da06, 5); calld(0x100b_8054, 0xa649);             /* call 0x100b8054 */
            ii(0x100a_da0b, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100a_da10, 2); if(jzd(0x100a_da20, 0xe)) goto l_0x100a_da20; /* jz 0x100ada20 */
            ii(0x100a_da12, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x100a_da17, 5); calld(0x100c_dec2, 0x2_04a6);           /* call 0x100cdec2 */
            ii(0x100a_da1c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_da1e, 2); if(jnzd(0x100a_da22, 0x2)) goto l_0x100a_da22; /* jnz 0x100ada22 */
        l_0x100a_da20:
            ii(0x100a_da20, 2); jmpd(0x100a_da60, 0x3e); goto l_0x100a_da60; /* jmp 0x100ada60 */
        l_0x100a_da22:
            ii(0x100a_da22, 5); mov(ebx, 0x4e);                         /* mov ebx, 0x4e */
            ii(0x100a_da27, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_da2a, 5); calld(0x1008_ad90, -0x2_2c9f);          /* call 0x1008ad90 */
            ii(0x100a_da2f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_da32, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100a_da37, 5); calld(0x100a_d632, -0x40a);             /* call 0x100ad632 */
            ii(0x100a_da3c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_da3e, 2); if(jnzd(0x100a_da5e, 0x1e)) goto l_0x100a_da5e; /* jnz 0x100ada5e */
            ii(0x100a_da40, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x100a_da45, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_da48, 5); calld(0x1008_ad90, -0x2_2cbd);          /* call 0x1008ad90 */
            ii(0x100a_da4d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_da50, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_da55, 5); calld(0x100a_d632, -0x428);             /* call 0x100ad632 */
            ii(0x100a_da5a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_da5c, 2); if(jzd(0x100a_da60, 0x2)) goto l_0x100a_da60; /* jz 0x100ada60 */
        l_0x100a_da5e:
            ii(0x100a_da5e, 2); jmpd(0x100a_da62, 0x2); goto l_0x100a_da62; /* jmp 0x100ada62 */
        l_0x100a_da60:
            ii(0x100a_da60, 2); jmpd(0x100a_da76, 0x14); goto l_0x100a_da76; /* jmp 0x100ada76 */
        l_0x100a_da62:
            ii(0x100a_da62, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x100a_da67, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_da6a, 5); calld(0x1008_a520, -0x2_354f);          /* call 0x1008a520 */
            ii(0x100a_da6f, 5); calld(0x100a_d86c, -0x208);             /* call 0x100ad86c */
            ii(0x100a_da74, 2); jmpd(0x100a_da88, 0x12); goto l_0x100a_da88; /* jmp 0x100ada88 */
        l_0x100a_da76:
            ii(0x100a_da76, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_da7b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_da7e, 5); calld(0x1008_a520, -0x2_3563);          /* call 0x1008a520 */
            ii(0x100a_da83, 5); calld(0x100a_d02d, -0xa5b);             /* call 0x100ad02d */
        l_0x100a_da88:
            ii(0x100a_da88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_da8a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_da8d, 5); calld(0x1008_8d4c, -0x2_4d46);          /* call 0x10088d4c */
            ii(0x100a_da92, 2); jmpd(0x100a_dae5, 0x51); goto l_0x100a_dae5; /* jmp 0x100adae5 */
        l_0x100a_da94:
            ii(0x100a_da94, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_da97, 5); calld(0x100b_8054, 0xa5b8);             /* call 0x100b8054 */
            ii(0x100a_da9c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_da9e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_daa1, 5); calld(0x1008_a520, -0x2_3586);          /* call 0x1008a520 */
            ii(0x100a_daa6, 4); mov(dx, memw_a32[ds, edx + 0x8]);       /* mov dx, [edx+0x8] */
            ii(0x100a_daaa, 4); mov(memw_a32[ds, eax + 0x26], dx);      /* mov [eax+0x26], dx */
            ii(0x100a_daae, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_dab1, 5); calld(0x1008_a520, -0x2_3596);          /* call 0x1008a520 */
            ii(0x100a_dab6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_dab8, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x100a_dabb, 3); mov(memb_a32[ds, edx + 0x47], al);      /* mov [edx+0x47], al */
            ii(0x100a_dabe, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_dac1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_dac4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_dac7, 5); calld(0x1007_5e64, -0x3_7c68);          /* call 0x10075e64 */
            ii(0x100a_dacc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_dace, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_dad1, 5); calld(0x1008_a520, -0x2_35b6);          /* call 0x1008a520 */
            ii(0x100a_dad6, 5); calld(0x100a_daed, 0x12);               /* call 0x100adaed */
            ii(0x100a_dadb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_dadd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_dae0, 5); calld(0x1008_8d4c, -0x2_4d99);          /* call 0x10088d4c */
        l_0x100a_dae5:
            ii(0x100a_dae5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_dae7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_dae8, 1); popd(edi);                              /* pop edi */
            ii(0x100a_dae9, 1); popd(esi);                              /* pop esi */
            ii(0x100a_daea, 3); retd(0x4);                              /* ret 0x4 */
        }
    }
}
