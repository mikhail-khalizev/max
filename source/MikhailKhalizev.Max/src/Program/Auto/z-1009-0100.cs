using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("412c5168-a006-4795-a9f0-6313f523b6c9")]
        public void Method_1009_0100()
        {
            ii(0x1009_0100, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1009_0105, 5); calld(Definitions.sys_check_available_stack_size, 0xd_5c48); /* call 0x10165d52 */
            ii(0x1009_010a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_010b, 1); pushd(esi);                             /* push esi */
            ii(0x1009_010c, 1); pushd(edi);                             /* push edi */
            ii(0x1009_010d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_010e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0110, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1009_0116, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_0119, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_011c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1009_011f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_0122, 3); add(edx, 0x26);                         /* add edx, 0x26 */
            ii(0x1009_0125, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0128, 5); calld(0x1007_6d98, -0x1_9395);          /* call 0x10076d98 */
            ii(0x1009_012d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_012f, 6); if(jzd(0x1009_0242, 0x10d)) goto l_0x1009_0242; /* jz 0x10090242 */
            ii(0x1009_0135, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0137, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_013a, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1009_013d, 5); calld(0x1009_c8f8, 0xc7b6);             /* call 0x1009c8f8 */
            ii(0x1009_0142, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_0145, 4); cmp(memb_a32[ds, eax + 0x25], 0x8);     /* cmp byte [eax+0x25], 0x8 */
            ii(0x1009_0149, 2); if(jnzd(0x1009_015c, 0x11)) goto l_0x1009_015c; /* jnz 0x1009015c */
            ii(0x1009_014b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_014d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_0150, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_0153, 5); calld(0x1013_ad71, 0xa_ac19);           /* call 0x1013ad71 */
            ii(0x1009_0158, 2); test(al, al);                           /* test al, al */
            ii(0x1009_015a, 2); if(jnzd(0x1009_0161, 0x5)) goto l_0x1009_0161; /* jnz 0x10090161 */
        l_0x1009_015c:
            ii(0x1009_015c, 5); jmpd(0x1009_0242, 0xe1); goto l_0x1009_0242; /* jmp 0x10090242 */
        l_0x1009_0161:
            ii(0x1009_0161, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1009_0165, 2); if(jnzd(0x1009_0174, 0xd)) goto l_0x1009_0174; /* jnz 0x10090174 */
            ii(0x1009_0167, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_016a, 5); calld(0x1008_f76b, -0xa04);             /* call 0x1008f76b */
            ii(0x1009_016f, 5); jmpd(0x1009_0242, 0xce); goto l_0x1009_0242; /* jmp 0x10090242 */
        l_0x1009_0174:
            ii(0x1009_0174, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_0177, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_017a, 5); calld(0x1007_6574, -0x1_9c0b);          /* call 0x10076574 */
            ii(0x1009_017f, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1009_0183, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_0186, 4); cmp(dx, memw_a32[ds, eax + 0x21]);      /* cmp dx, [eax+0x21] */
            ii(0x1009_018a, 2); if(jnzd(0x1009_01a4, 0x18)) goto l_0x1009_01a4; /* jnz 0x100901a4 */
            ii(0x1009_018c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_018f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_0192, 5); calld(0x1007_6574, -0x1_9c23);          /* call 0x10076574 */
            ii(0x1009_0197, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1009_019b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_019e, 4); cmp(dx, memw_a32[ds, eax + 0x23]);      /* cmp dx, [eax+0x23] */
            ii(0x1009_01a2, 2); if(jzd(0x1009_01a6, 0x2)) goto l_0x1009_01a6; /* jz 0x100901a6 */
        l_0x1009_01a4:
            ii(0x1009_01a4, 2); jmpd(0x1009_01b3, 0xd); goto l_0x1009_01b3; /* jmp 0x100901b3 */
        l_0x1009_01a6:
            ii(0x1009_01a6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_01a9, 5); calld(0x1008_dbbd, -0x25f1);            /* call 0x1008dbbd */
            ii(0x1009_01ae, 5); jmpd(0x1009_0242, 0x8f); goto l_0x1009_0242; /* jmp 0x10090242 */
        l_0x1009_01b3:
            ii(0x1009_01b3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_01b6, 4); mov(memb_a32[ds, eax + 0x25], 0x7);     /* mov byte [eax+0x25], 0x7 */
            ii(0x1009_01ba, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1009_01bf, 5); calld(Definitions.sys_new, 0xd_5c3c);   /* call 0x10165e00 */
            ii(0x1009_01c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_01c7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_01ca, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_01cd, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_01d1, 2); if(jzd(0x1009_0213, 0x40)) goto l_0x1009_0213; /* jz 0x10090213 */
            ii(0x1009_01d3, 5); mov(eax, 0x1009_0249);                  /* mov eax, 0x10090249 */
            ii(0x1009_01d8, 1); pushd(eax);                             /* push eax */
            ii(0x1009_01d9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_01dc, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1009_01df, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_01e2, 5); calld(0x1007_5e64, -0x1_a383);          /* call 0x10075e64 */
            ii(0x1009_01e7, 1); pushd(eax);                             /* push eax */
            ii(0x1009_01e8, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1009_01ed, 1); pushd(eax);                             /* push eax */
            ii(0x1009_01ee, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_01f0, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1009_01f3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_01f6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_01f9, 5); calld(0x1007_65d0, -0x1_9c2e);          /* call 0x100765d0 */
            ii(0x1009_01fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0200, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0203, 5); calld(0x100a_c220, 0x1_c018);           /* call 0x100ac220 */
            ii(0x1009_0208, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_020b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_020e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_0211, 2); jmpd(0x1009_0219, 0x6); goto l_0x1009_0219; /* jmp 0x10090219 */
        l_0x1009_0213:
            ii(0x1009_0213, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_0216, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1009_0219:
            ii(0x1009_0219, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1009_021c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_021f, 5); calld(0x1008_b060, -0x51c4);            /* call 0x1008b060 */
            ii(0x1009_0224, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0227, 5); calld(0x1008_af84, -0x52a8);            /* call 0x1008af84 */
            ii(0x1009_022c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_022e, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_0233, 5); calld(0x100a_4d50, 0x1_4b18);           /* call 0x100a4d50 */
            ii(0x1009_0238, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_023a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_023d, 5); calld(0x1008_8b7c, -0x76c6);            /* call 0x10088b7c */
        l_0x1009_0242:
            ii(0x1009_0242, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0244, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_0245, 1); popd(edi);                              /* pop edi */
            ii(0x1009_0246, 1); popd(esi);                              /* pop esi */
            ii(0x1009_0247, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_0248, 1); retd(); return;                         /* ret */
        }
    }
}
