using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f15d-f5a7f5de")]
        public void Method_1007_f15d()
        {
            ii(0x1007_f15d, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_f162, 5); call(Definitions.sys_check_available_stack_size, 0xe_6beb); /* call 0x10165d52 */
            ii(0x1007_f167, 1); push(ebx);                              /* push ebx */
            ii(0x1007_f168, 1); push(ecx);                              /* push ecx */
            ii(0x1007_f169, 1); push(edx);                              /* push edx */
            ii(0x1007_f16a, 1); push(esi);                              /* push esi */
            ii(0x1007_f16b, 1); push(edi);                              /* push edi */
            ii(0x1007_f16c, 1); push(ebp);                              /* push ebp */
            ii(0x1007_f16d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f16f, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_f175, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_f178, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f17a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f17d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f180, 5); call(0x1013_ad71, 0xb_bbec);            /* call 0x1013ad71 */
            ii(0x1007_f185, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f187, 2); if(jz(0x1007_f19a, 0x11)) goto l_0x1007_f19a; /* jz 0x1007f19a */
            ii(0x1007_f189, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f18c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f18f, 5); call(0x1007_6574, -0x8c20);             /* call 0x10076574 */
            ii(0x1007_f194, 4); cmp(memb[ds, eax + 89], 0);             /* cmp byte [eax+0x59], 0x0 */
            ii(0x1007_f198, 2); if(jz(0x1007_f19c, 2)) goto l_0x1007_f19c; /* jz 0x1007f19c */
        l_0x1007_f19a:
            ii(0x1007_f19a, 2); jmp(0x1007_f1ab, 0xf); goto l_0x1007_f1ab; /* jmp 0x1007f1ab */
        l_0x1007_f19c:
            ii(0x1007_f19c, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1007_f1a1, 5); call(0x1007_6b90, -0x8616);             /* call 0x10076b90 */
            ii(0x1007_f1a6, 1); cwde();                                 /* cwde */
            ii(0x1007_f1a7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_f1a9, 2); if(jz(0x1007_f1ad, 2)) goto l_0x1007_f1ad; /* jz 0x1007f1ad */
        l_0x1007_f1ab:
            ii(0x1007_f1ab, 2); jmp(0x1007_f1ba, 0xd); goto l_0x1007_f1ba; /* jmp 0x1007f1ba */
        l_0x1007_f1ad:
            ii(0x1007_f1ad, 5); mov(eax, memd[ds, 0x101c_31be]);        /* mov eax, [0x101c31be] */
            ii(0x1007_f1b2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_f1b5, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1007_f1b8, 2); if(jnz(0x1007_f1bc, 2)) goto l_0x1007_f1bc; /* jnz 0x1007f1bc */
        l_0x1007_f1ba:
            ii(0x1007_f1ba, 2); jmp(0x1007_f20b, 0x4f); goto l_0x1007_f20b; /* jmp 0x1007f20b */
        l_0x1007_f1bc:
            ii(0x1007_f1bc, 5); call(0x1008_9aac, 0xa8eb);              /* call 0x10089aac */
            ii(0x1007_f1c1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f1c3, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1007_f1c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f1c8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f1cb, 5); call(0x1007_65d0, -0x8c00);             /* call 0x100765d0 */
            ii(0x1007_f1d0, 5); call(0x1007_8840, -0x6995);             /* call 0x10078840 */
            ii(0x1007_f1d5, 5); call(0x1008_ac50, 0xba76);              /* call 0x1008ac50 */
            ii(0x1007_f1da, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_f1dc, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_f1de, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_f1e1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f1e4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f1e7, 5); call(0x1007_6574, -0x8c78);             /* call 0x10076574 */
            ii(0x1007_f1ec, 5); call(0x1015_2962, 0xd_3771);            /* call 0x10152962 */
            ii(0x1007_f1f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f1f3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f1f6, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_f1f9, 5); call(0x1008_afe4, 0xbde6);              /* call 0x1008afe4 */
            ii(0x1007_f1fe, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_f201, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_f206, 5); call(0x100a_5e27, 0x2_6c1c);            /* call 0x100a5e27 */
        l_0x1007_f20b:
            ii(0x1007_f20b, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_f20f, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1007_f212, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f214, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_f215, 1); pop(edi);                               /* pop edi */
            ii(0x1007_f216, 1); pop(esi);                               /* pop esi */
            ii(0x1007_f217, 1); pop(edx);                               /* pop edx */
            ii(0x1007_f218, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_f219, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_f21a, 1); ret();                                  /* ret */
        }
    }
}
