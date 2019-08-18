using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04fb3973-0627-4e9b-9cb5-71ae61e4dbce")]
        public void Method_100e_a7e7()
        {
            ii(0x100e_a7e7, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100e_a7ec, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b561); /* call 0x10165d52 */
            ii(0x100e_a7f1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_a7f2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_a7f3, 1); pushd(edx);                             /* push edx */
            ii(0x100e_a7f4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a7f5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a7f6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a7f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a7f9, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_a7ff, 5); calld(/* sys */ 0x1016_b258, 0x8_0a54); /* call 0x1016b258 */
            ii(0x100e_a804, 5); calld(/* sys */ 0x1016_c348, 0x8_1b3f); /* call 0x1016c348 */
            ii(0x100e_a809, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100e_a80c, 4); test(memb_a32[ss, ebp - 0x4], 0x4);     /* test byte [ebp-0x4], 0x4 */
            ii(0x100e_a810, 2); if(jzd(0x100e_a816, 0x4)) goto l_0x100e_a816; /* jz 0x100ea816 */
            ii(0x100e_a812, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
        l_0x100e_a816:
            ii(0x100e_a816, 4); test(memb_a32[ss, ebp - 0x4], 0x8);     /* test byte [ebp-0x4], 0x8 */
            ii(0x100e_a81a, 2); if(jzd(0x100e_a820, 0x4)) goto l_0x100e_a820; /* jz 0x100ea820 */
            ii(0x100e_a81c, 4); or(memb_a32[ss, ebp - 0x4], 0x2);       /* or byte [ebp-0x4], 0x2 */
        l_0x100e_a820:
            ii(0x100e_a820, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_a823, 6); cmp(al, memb_a32[ds, 0x101c_3674]);     /* cmp al, [0x101c3674] */
            ii(0x100e_a829, 6); if(jzd(0x100e_a8fa, 0xcb)) goto l_0x100e_a8fa; /* jz 0x100ea8fa */
            ii(0x100e_a82f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_a832, 5); calld(0x100e_ad24, 0x4ed);              /* call 0x100ead24 */
            ii(0x100e_a837, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x100e_a83a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_a83d, 5); calld(/* sys */ 0x1016_c298, 0x8_1a56); /* call 0x1016c298 */
            ii(0x100e_a842, 4); test(memb_a32[ss, ebp - 0x4], 0x1);     /* test byte [ebp-0x4], 0x1 */
            ii(0x100e_a846, 2); if(jzd(0x100e_a872, 0x2a)) goto l_0x100e_a872; /* jz 0x100ea872 */
            ii(0x100e_a848, 7); test(memb_a32[ds, 0x101c_3674], 0x1);   /* test byte [0x101c3674], 0x1 */
            ii(0x100e_a84f, 2); if(jnzd(0x100e_a870, 0x1f)) goto l_0x100e_a870; /* jnz 0x100ea870 */
            ii(0x100e_a851, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100e_a855, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a858, 4); mov(memw_a32[ss, ebp - 0x13], ax);      /* mov [ebp-0x13], ax */
            ii(0x100e_a85c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a85f, 4); mov(memw_a32[ss, ebp - 0x11], ax);      /* mov [ebp-0x11], ax */
            ii(0x100e_a863, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100e_a866, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a86b, 5); calld(0x100e_ae08, 0x598);              /* call 0x100eae08 */
        l_0x100e_a870:
            ii(0x100e_a870, 2); jmpd(0x100e_a89a, 0x28); goto l_0x100e_a89a; /* jmp 0x100ea89a */
        l_0x100e_a872:
            ii(0x100e_a872, 7); test(memb_a32[ds, 0x101c_3674], 0x1);   /* test byte [0x101c3674], 0x1 */
            ii(0x100e_a879, 2); if(jzd(0x100e_a89a, 0x1f)) goto l_0x100e_a89a; /* jz 0x100ea89a */
            ii(0x100e_a87b, 4); mov(memb_a32[ss, ebp - 0x14], 0x10);    /* mov byte [ebp-0x14], 0x10 */
            ii(0x100e_a87f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a882, 4); mov(memw_a32[ss, ebp - 0x13], ax);      /* mov [ebp-0x13], ax */
            ii(0x100e_a886, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a889, 4); mov(memw_a32[ss, ebp - 0x11], ax);      /* mov [ebp-0x11], ax */
            ii(0x100e_a88d, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100e_a890, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a895, 5); calld(0x100e_ae08, 0x56e);              /* call 0x100eae08 */
        l_0x100e_a89a:
            ii(0x100e_a89a, 4); test(memb_a32[ss, ebp - 0x4], 0x2);     /* test byte [ebp-0x4], 0x2 */
            ii(0x100e_a89e, 2); if(jzd(0x100e_a8ca, 0x2a)) goto l_0x100e_a8ca; /* jz 0x100ea8ca */
            ii(0x100e_a8a0, 7); test(memb_a32[ds, 0x101c_3674], 0x2);   /* test byte [0x101c3674], 0x2 */
            ii(0x100e_a8a7, 2); if(jnzd(0x100e_a8c8, 0x1f)) goto l_0x100e_a8c8; /* jnz 0x100ea8c8 */
            ii(0x100e_a8a9, 4); mov(memb_a32[ss, ebp - 0x14], 0x2);     /* mov byte [ebp-0x14], 0x2 */
            ii(0x100e_a8ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a8b0, 4); mov(memw_a32[ss, ebp - 0x13], ax);      /* mov [ebp-0x13], ax */
            ii(0x100e_a8b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a8b7, 4); mov(memw_a32[ss, ebp - 0x11], ax);      /* mov [ebp-0x11], ax */
            ii(0x100e_a8bb, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100e_a8be, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a8c3, 5); calld(0x100e_ae08, 0x540);              /* call 0x100eae08 */
        l_0x100e_a8c8:
            ii(0x100e_a8c8, 2); jmpd(0x100e_a8f2, 0x28); goto l_0x100e_a8f2; /* jmp 0x100ea8f2 */
        l_0x100e_a8ca:
            ii(0x100e_a8ca, 7); test(memb_a32[ds, 0x101c_3674], 0x2);   /* test byte [0x101c3674], 0x2 */
            ii(0x100e_a8d1, 2); if(jzd(0x100e_a8f2, 0x1f)) goto l_0x100e_a8f2; /* jz 0x100ea8f2 */
            ii(0x100e_a8d3, 4); mov(memb_a32[ss, ebp - 0x14], 0x20);    /* mov byte [ebp-0x14], 0x20 */
            ii(0x100e_a8d7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_a8da, 4); mov(memw_a32[ss, ebp - 0x13], ax);      /* mov [ebp-0x13], ax */
            ii(0x100e_a8de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a8e1, 4); mov(memw_a32[ss, ebp - 0x11], ax);      /* mov [ebp-0x11], ax */
            ii(0x100e_a8e5, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100e_a8e8, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a8ed, 5); calld(0x100e_ae08, 0x516);              /* call 0x100eae08 */
        l_0x100e_a8f2:
            ii(0x100e_a8f2, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_a8f5, 5); mov(memb_a32[ds, 0x101c_3674], al);     /* mov [0x101c3674], al */
        l_0x100e_a8fa:
            ii(0x100e_a8fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a8fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a8fd, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a8fe, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a8ff, 1); popd(edx);                              /* pop edx */
            ii(0x100e_a900, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_a901, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_a902, 1); retd(); return;                         /* ret */
        }
    }
}
