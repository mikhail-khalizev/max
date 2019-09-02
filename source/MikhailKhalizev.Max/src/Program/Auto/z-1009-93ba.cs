using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_93ba-8a3b7ac5")]
        public void Method_1009_93ba()
        {
            ii(0x1009_93ba, 5); push(0x38);                             /* push 0x38 */
            ii(0x1009_93bf, 5); call(Definitions.sys_check_available_stack_size, 0xc_c98e); /* call 0x10165d52 */
            ii(0x1009_93c4, 1); push(ebx);                              /* push ebx */
            ii(0x1009_93c5, 1); push(ecx);                              /* push ecx */
            ii(0x1009_93c6, 1); push(edx);                              /* push edx */
            ii(0x1009_93c7, 1); push(esi);                              /* push esi */
            ii(0x1009_93c8, 1); push(edi);                              /* push edi */
            ii(0x1009_93c9, 1); push(ebp);                              /* push ebp */
            ii(0x1009_93ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_93cc, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_93d2, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_93d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_93d8, 4); cmp(memb[ds, eax + 29], 2);             /* cmp byte [eax+0x1d], 0x2 */
            ii(0x1009_93dc, 2); if(jnz(0x1009_93e6, 8)) goto l_0x1009_93e6; /* jnz 0x100993e6 */
            ii(0x1009_93de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_93e1, 5); call(0x1009_8cc9, -0x71d);              /* call 0x10098cc9 */
        l_0x1009_93e6:
            ii(0x1009_93e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_93e9, 4); cmp(memb[ds, eax + 29], 3);             /* cmp byte [eax+0x1d], 0x3 */
            ii(0x1009_93ed, 2); if(jnz(0x1009_9400, 0x11)) goto l_0x1009_9400; /* jnz 0x10099400 */
            ii(0x1009_93ef, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_93f2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_93f5, 5); call(0x1007_6574, -0x2_2e86);           /* call 0x10076574 */
            ii(0x1009_93fa, 4); cmp(memb[ds, eax + 62], 0x1f);          /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1009_93fe, 2); if(jz(0x1009_9405, 5)) goto l_0x1009_9405; /* jz 0x10099405 */
        l_0x1009_9400:
            ii(0x1009_9400, 5); jmp(0x1009_94a1, 0x9c); goto l_0x1009_94a1; /* jmp 0x100994a1 */
        l_0x1009_9405:
            ii(0x1009_9405, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9408, 4); mov(memb[ds, eax + 29], 4);             /* mov byte [eax+0x1d], 0x4 */
            ii(0x1009_940c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_940f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9412, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9415, 5); call(0x1007_6574, -0x2_2ea6);           /* call 0x10076574 */
            ii(0x1009_941a, 5); call(0x1007_611c, -0x2_3303);           /* call 0x1007611c */
            ii(0x1009_941f, 5); call(0x1015_27ed, 0xb_93c9);            /* call 0x101527ed */
            ii(0x1009_9424, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1009_9429, 5); call(Definitions.sys_new, 0xc_c9d2);    /* call 0x10165e00 */
            ii(0x1009_942e, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_9431, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_9434, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1009_9437, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_943b, 2); if(jz(0x1009_9472, 0x35)) goto l_0x1009_9472; /* jz 0x10099472 */
            ii(0x1009_943d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9440, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9443, 5); call(0x1007_65d0, -0x2_2e78);           /* call 0x100765d0 */
            ii(0x1009_9448, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1009_944a, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1009_944d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9450, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9453, 5); call(0x1007_6574, -0x2_2ee4);           /* call 0x10076574 */
            ii(0x1009_9458, 5); call(0x1007_611c, -0x2_3341);           /* call 0x1007611c */
            ii(0x1009_945d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_945f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_9462, 5); call(0x100b_3871, 0x1_a40a);            /* call 0x100b3871 */
            ii(0x1009_9467, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1009_946a, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1009_946d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_9470, 2); jmp(0x1009_9478, 6); goto l_0x1009_9478; /* jmp 0x10099478 */
        l_0x1009_9472:
            ii(0x1009_9472, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_9475, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1009_9478:
            ii(0x1009_9478, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1009_947b, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_947e, 5); call(0x1008_b060, -0xe423);             /* call 0x1008b060 */
            ii(0x1009_9483, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_9486, 5); call(0x1008_af84, -0xe507);             /* call 0x1008af84 */
            ii(0x1009_948b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_948d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_9492, 5); call(0x100a_4d50, 0xb8b9);              /* call 0x100a4d50 */
            ii(0x1009_9497, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9499, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_949c, 5); call(0x1008_8b7c, -0x1_0925);           /* call 0x10088b7c */
        l_0x1009_94a1:
            ii(0x1009_94a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_94a4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_94a7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_94aa, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1009_94ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_94b0, 3); call_abs(memd[ds, edx + 60]);           /* call dword [edx+0x3c] */
            ii(0x1009_94b3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_94b5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_94b6, 1); pop(edi);                               /* pop edi */
            ii(0x1009_94b7, 1); pop(esi);                               /* pop esi */
            ii(0x1009_94b8, 1); pop(edx);                               /* pop edx */
            ii(0x1009_94b9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_94ba, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_94bb, 1); ret();                                  /* ret */
        }
    }
}
