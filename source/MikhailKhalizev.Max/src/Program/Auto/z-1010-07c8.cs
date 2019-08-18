using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_07c8-85c0038")]
        public void Method_1010_07c8()
        {
            ii(0x1010_07c8, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1010_07cd, 5); calld(Definitions.sys_check_available_stack_size, 0x6_5580); /* call 0x10165d52 */
            ii(0x1010_07d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_07d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_07d4, 1); pushd(edx);                             /* push edx */
            ii(0x1010_07d5, 1); pushd(esi);                             /* push esi */
            ii(0x1010_07d6, 1); pushd(edi);                             /* push edi */
            ii(0x1010_07d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_07d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_07da, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_07e0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_07e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_07e6, 5); calld(0x1007_623c, -0x8_a5af);          /* call 0x1007623c */
            ii(0x1010_07eb, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1010_07ee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_07f0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_07f2, 5); calld(0x1007_6800, -0x8_9ff7);          /* call 0x10076800 */
            ii(0x1010_07f7, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1010_07fb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_07fe, 5); calld(Definitions.my_string_ctor, 0x4_12e5); /* call 0x10141ae8 */
            ii(0x1010_0803, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_0806, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1010_080a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_080d, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1010_0811, 2); if(jnzd(0x1010_0823, 0x10)) goto l_0x1010_0823; /* jnz 0x10100823 */
            ii(0x1010_0813, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0816, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1010_0819, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_081e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_0821, 2); if(jnzd(0x1010_0825, 0x2)) goto l_0x1010_0825; /* jnz 0x10100825 */
        l_0x1010_0823:
            ii(0x1010_0823, 2); jmpd(0x1010_086d, 0x48); goto l_0x1010_086d; /* jmp 0x1010086d */
        l_0x1010_0825:
            ii(0x1010_0825, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0828, 3); mov(al, memb_a32[ds, eax + 0x58]);      /* mov al, [eax+0x58] */
            ii(0x1010_082b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_0830, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_0833, 2); if(jnzd(0x1010_0844, 0xf)) goto l_0x1010_0844; /* jnz 0x10100844 */
            ii(0x1010_0835, 5); mov(edx, StringDefinitions.Disabled1Turn); /* mov edx, 0x101a2b74 */
            ii(0x1010_083a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_083d, 5); calld(0x1014_21cb, 0x4_1989);           /* call 0x101421cb */
            ii(0x1010_0842, 2); jmpd(0x1010_0868, 0x24); goto l_0x1010_0868; /* jmp 0x10100868 */
        l_0x1010_0844:
            ii(0x1010_0844, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0847, 3); mov(al, memb_a32[ds, eax + 0x58]);      /* mov al, [eax+0x58] */
            ii(0x1010_084a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_084f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0850, 5); mov(eax, StringDefinitions.DisabledITurns); /* mov eax, 0x101a2b85 */
            ii(0x1010_0855, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0856, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1010_085b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_085c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_085f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0860, 5); calld(0x1014_2037, 0x4_17d2);           /* call 0x10142037 */
            ii(0x1010_0865, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1010_0868:
            ii(0x1010_0868, 5); jmpd(0x1010_090c, 0x9f); goto l_0x1010_090c; /* jmp 0x1010090c */
        l_0x1010_086d:
            ii(0x1010_086d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0870, 3); mov(edx, memd_a32[ds, eax + 0x3a]);     /* mov edx, [eax+0x3a] */
            ii(0x1010_0873, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1010_0876, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_0879, 6); mov(edx, memd_a32[ds, edx + 0x101b_8978]); /* mov edx, [edx+0x101b8978] */
            ii(0x1010_087f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_0882, 5); calld(0x1014_21cb, 0x4_1944);           /* call 0x101421cb */
            ii(0x1010_0887, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_088a, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1010_088e, 2); if(jzd(0x1010_0899, 0x9)) goto l_0x1010_0899; /* jz 0x10100899 */
            ii(0x1010_0890, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0893, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1010_0897, 2); if(jnzd(0x1010_08ac, 0x13)) goto l_0x1010_08ac; /* jnz 0x101008ac */
        l_0x1010_0899:
            ii(0x1010_0899, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_089c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_089e, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_08a1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_08a3, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_08a8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_08aa, 2); if(jzd(0x1010_08ae, 0x2)) goto l_0x1010_08ae; /* jz 0x101008ae */
        l_0x1010_08ac:
            ii(0x1010_08ac, 2); jmpd(0x1010_090c, 0x5e); goto l_0x1010_090c; /* jmp 0x1010090c */
        l_0x1010_08ae:
            ii(0x1010_08ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_08b1, 4); cmp(memb_a32[ds, eax + 0x5c], 0);       /* cmp byte [eax+0x5c], 0x0 */
            ii(0x1010_08b5, 2); if(jzd(0x1010_08c4, 0xd)) goto l_0x1010_08c4; /* jz 0x101008c4 */
            ii(0x1010_08b7, 5); mov(edx, StringDefinitions.Surveying);  /* mov edx, 0x101a2b98 */
            ii(0x1010_08bc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_08bf, 5); calld(0x1014_21cb, 0x4_1907);           /* call 0x101421cb */
        l_0x1010_08c4:
            ii(0x1010_08c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_08c7, 4); cmp(memb_a32[ds, eax + 0x5b], 0);       /* cmp byte [eax+0x5b], 0x0 */
            ii(0x1010_08cb, 2); if(jzd(0x1010_08da, 0xd)) goto l_0x1010_08da; /* jz 0x101008da */
            ii(0x1010_08cd, 5); mov(edx, StringDefinitions.ReactionFireOff); /* mov edx, 0x101a2ba2 */
            ii(0x1010_08d2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_08d5, 5); calld(0x1014_21cb, 0x4_18f1);           /* call 0x101421cb */
        l_0x1010_08da:
            ii(0x1010_08da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_08dd, 5); calld(0x1008_aa4c, -0x7_5e96);          /* call 0x1008aa4c */
            ii(0x1010_08e2, 2); cmp(al, 0x2);                           /* cmp al, 0x2 */
            ii(0x1010_08e4, 2); if(jnzd(0x1010_08f3, 0xd)) goto l_0x1010_08f3; /* jnz 0x101008f3 */
            ii(0x1010_08e6, 5); mov(edx, StringDefinitions.PlacingMines); /* mov edx, 0x101a2bb4 */
            ii(0x1010_08eb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_08ee, 5); calld(0x1014_21cb, 0x4_18d8);           /* call 0x101421cb */
        l_0x1010_08f3:
            ii(0x1010_08f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_08f6, 5); calld(0x1008_aa4c, -0x7_5eaf);          /* call 0x1008aa4c */
            ii(0x1010_08fb, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1010_08fd, 2); if(jnzd(0x1010_090c, 0xd)) goto l_0x1010_090c; /* jnz 0x1010090c */
            ii(0x1010_08ff, 5); mov(edx, StringDefinitions.RemovingMines); /* mov edx, 0x101a2bc2 */
            ii(0x1010_0904, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_0907, 5); calld(0x1014_21cb, 0x4_18bf);           /* call 0x101421cb */
        l_0x1010_090c:
            ii(0x1010_090c, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1010_090f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_0912, 5); calld(Definitions.my_string_ctor_string, 0x4_118f); /* call 0x10141aa6 */
            ii(0x1010_0917, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0919, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_091c, 5); calld(Definitions.my_string_dtor, 0x4_1209); /* call 0x10141b2a */
            ii(0x1010_0921, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0923, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_0926, 5); calld(0x1007_5eec, -0x8_aa3f);          /* call 0x10075eec */
            ii(0x1010_092b, 2); jmpd(0x1010_0941, 0x14); goto l_0x1010_0941; /* jmp 0x10100941 */
        //    ii(0x1010_092d, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1010_092f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //    ii(0x1010_0932, 5); calld(Definitions.my_string_dtor, 0x4_11f3); /* call 0x10141b2a */
        //    ii(0x1010_0937, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1010_0939, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x1010_093c, 5); calld(0x1007_5eec, -0x8_aa55);          /* call 0x10075eec */
        l_0x1010_0941:
            ii(0x1010_0941, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_0944, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_0946, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_0947, 1); popd(edi);                              /* pop edi */
            ii(0x1010_0948, 1); popd(esi);                              /* pop esi */
            ii(0x1010_0949, 1); popd(edx);                              /* pop edx */
            ii(0x1010_094a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_094b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_094c, 1); retd(); return;                         /* ret */
        }
    }
}
