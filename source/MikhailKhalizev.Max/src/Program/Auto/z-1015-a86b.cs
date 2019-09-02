using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_a86b-5b597fe3")]
        public void Method_1015_a86b()
        {
            ii(0x1015_a86b, 5); push(0x44);                             /* push 0x44 */
            ii(0x1015_a870, 5); call(Definitions.sys_check_available_stack_size, 0xb4dd); /* call 0x10165d52 */
            ii(0x1015_a875, 1); push(ecx);                              /* push ecx */
            ii(0x1015_a876, 1); push(esi);                              /* push esi */
            ii(0x1015_a877, 1); push(edi);                              /* push edi */
            ii(0x1015_a878, 1); push(ebp);                              /* push ebp */
            ii(0x1015_a879, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_a87b, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_a881, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_a884, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1015_a887, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1015_a88a, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1015_a88e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_a891, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_a894, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_a896, 1); cwde();                                 /* cwde */
            ii(0x1015_a897, 1); push(eax);                              /* push eax */
            ii(0x1015_a898, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_a89d, 1); push(eax);                              /* push eax */
            ii(0x1015_a89e, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_a8a1, 1); push(eax);                              /* push eax */
            ii(0x1015_a8a2, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1015_a8a5, 1); push(eax);                              /* push eax */
            ii(0x1015_a8a6, 3); lea(ecx, memd[ss, ebp - 0x1c]);         /* lea ecx, [ebp-0x1c] */
            ii(0x1015_a8a9, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_a8ae, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a8b2, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_a8b6, 5); call(0x1014_2d0b, -0x1_7bb0);           /* call 0x10142d0b */
            ii(0x1015_a8bb, 5); cmp(memw[ss, ebp - 0x1c], 0);           /* cmp word [ebp-0x1c], 0x0 */
            ii(0x1015_a8c0, 2); if(jz(0x1015_a8d2, 0x10)) goto l_0x1015_a8d2; /* jz 0x1015a8d2 */
            ii(0x1015_a8c2, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1015_a8c7, 5); call(0x1007_1ec5, -0xe_8a07);           /* call 0x10071ec5 */
            ii(0x1015_a8cc, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1015_a8d0, 2); if(jl(0x1015_a8d7, 5)) goto l_0x1015_a8d7; /* jl 0x1015a8d7 */
        l_0x1015_a8d2:
            ii(0x1015_a8d2, 5); jmp(0x1015_a96f, 0x98); goto l_0x1015_a96f; /* jmp 0x1015a96f */
        l_0x1015_a8d7:
            ii(0x1015_a8d7, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_a8da, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_a8df, 5); call(0x1010_3752, -0x5_7192);           /* call 0x10103752 */
            ii(0x1015_a8e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a8e6, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x1015_a8eb, 5); call(0x1013_ad71, -0x1_fb7f);           /* call 0x1013ad71 */
            ii(0x1015_a8f0, 2); test(al, al);                           /* test al, al */
            ii(0x1015_a8f2, 2); if(jz(0x1015_a90c, 0x18)) goto l_0x1015_a90c; /* jz 0x1015a90c */
            ii(0x1015_a8f4, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x1015_a8f9, 5); call(0x1007_6600, -0xe_42fe);           /* call 0x10076600 */
            ii(0x1015_a8fe, 5); mov(ebx, 0x101c_39b8);                  /* mov ebx, 0x101c39b8 */
            ii(0x1015_a903, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_a905, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_a907, 5); call(0x1010_3752, -0x5_71ba);           /* call 0x10103752 */
        l_0x1015_a90c:
            ii(0x1015_a90c, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1015_a910, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_a914, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1015_a919, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_a91c, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_a91f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_a921, 1); cwde();                                 /* cwde */
            ii(0x1015_a922, 5); call(0x100c_e099, -0x8_c88e);           /* call 0x100ce099 */
            ii(0x1015_a927, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1015_a92a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a92c, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x1015_a931, 5); call(0x1013_ad71, -0x1_fbc5);           /* call 0x1013ad71 */
            ii(0x1015_a936, 2); test(al, al);                           /* test al, al */
            ii(0x1015_a938, 2); if(jz(0x1015_a959, 0x1f)) goto l_0x1015_a959; /* jz 0x1015a959 */
            ii(0x1015_a93a, 5); call(0x100d_53f0, -0x8_554f);           /* call 0x100d53f0 */
            ii(0x1015_a93f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_a941, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_a943, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x1015_a948, 5); call(0x1007_6600, -0xe_434d);           /* call 0x10076600 */
            ii(0x1015_a94d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_a94f, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_a954, 5); call(0x1010_346f, -0x5_74ea);           /* call 0x1010346f */
        l_0x1015_a959:
            ii(0x1015_a959, 5); call(0x100d_53f0, -0x8_556e);           /* call 0x100d53f0 */
            ii(0x1015_a95e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_a960, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_a962, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_a965, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_a96a, 5); call(0x1010_346f, -0x5_7500);           /* call 0x1010346f */
        l_0x1015_a96f:
            ii(0x1015_a96f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_a971, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1015_a974, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1015_a977, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1015_a97a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_a97c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_a97d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_a97e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_a97f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_a980, 1); ret();                                  /* ret */
        }
    }
}
