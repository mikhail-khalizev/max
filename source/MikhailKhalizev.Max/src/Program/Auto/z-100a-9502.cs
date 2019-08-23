using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9502-f7ee395c")]
        public void Method_100a_9502()
        {
            ii(0x100a_9502, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_9507, 5); call(Definitions.sys_check_available_stack_size, 0xb_c846); /* call 0x10165d52 */
            ii(0x100a_950c, 1); push(ebx);                              /* push ebx */
            ii(0x100a_950d, 1); push(ecx);                              /* push ecx */
            ii(0x100a_950e, 1); push(edx);                              /* push edx */
            ii(0x100a_950f, 1); push(esi);                              /* push esi */
            ii(0x100a_9510, 1); push(edi);                              /* push edi */
            ii(0x100a_9511, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9512, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9514, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_951a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_951c, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100a_9521, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_9524, 6); if(jz(0x100a_95b8, 0x8e)) goto l_0x100a_95b8; /* jz 0x100a95b8 */
            ii(0x100a_952a, 5); call(0x100a_9395, -0x19a);              /* call 0x100a9395 */
            ii(0x100a_952f, 2); test(al, al);                           /* test al, al */
            ii(0x100a_9531, 2); if(jz(0x100a_9541, 0xe)) goto l_0x100a_9541; /* jz 0x100a9541 */
            ii(0x100a_9533, 9); mov(memw[ds, 0x101c_31c0], 0x2);        /* mov word [0x101c31c0], 0x2 */
            ii(0x100a_953c, 5); jmp(0x100a_95b8, 0x77); goto l_0x100a_95b8; /* jmp 0x100a95b8 */
        l_0x100a_9541:
            ii(0x100a_9541, 5); mov(eax, memd[ds, 0x101c_31be]);        /* mov eax, [0x101c31be] */
            ii(0x100a_9546, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9549, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_954c, 2); if(jnz(0x100a_9563, 0x15)) goto l_0x100a_9563; /* jnz 0x100a9563 */
            ii(0x100a_954e, 9); mov(memw[ds, 0x101c_31c0], 0x1);        /* mov word [0x101c31c0], 0x1 */
            ii(0x100a_9557, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_955c, 5); call(0x100a_40b3, -0x54ae);             /* call 0x100a40b3 */
            ii(0x100a_9561, 2); jmp(0x100a_95b8, 0x55); goto l_0x100a_95b8; /* jmp 0x100a95b8 */
        l_0x100a_9563:
            ii(0x100a_9563, 5); call(0x100a_93e5, -0x183);              /* call 0x100a93e5 */
            ii(0x100a_9568, 2); test(al, al);                           /* test al, al */
            ii(0x100a_956a, 2); if(jz(0x100a_9577, 0xb)) goto l_0x100a_9577; /* jz 0x100a9577 */
            ii(0x100a_956c, 9); mov(memw[ds, 0x101c_31c0], 0x1);        /* mov word [0x101c31c0], 0x1 */
            ii(0x100a_9575, 2); jmp(0x100a_9598, 0x21); goto l_0x100a_9598; /* jmp 0x100a9598 */
        l_0x100a_9577:
            ii(0x100a_9577, 5); mov(eax, memd[ds, 0x101c_31be]);        /* mov eax, [0x101c31be] */
            ii(0x100a_957c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_957f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_9581, 2); if(jz(0x100a_9598, 0x15)) goto l_0x100a_9598; /* jz 0x100a9598 */
            ii(0x100a_9583, 9); mov(memw[ds, 0x101c_31c0], 0);          /* mov word [0x101c31c0], 0x0 */
            ii(0x100a_958c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_9591, 5); call(0x100a_40b3, -0x54e3);             /* call 0x100a40b3 */
            ii(0x100a_9596, 2); jmp(0x100a_95b8, 0x20); goto l_0x100a_95b8; /* jmp 0x100a95b8 */
        l_0x100a_9598:
            ii(0x100a_9598, 5); call(0x1014_82f4, 0x9_ed57);            /* call 0x101482f4 */
            ii(0x100a_959d, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_95a0, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_95a5, 5); call(0x100a_4e00, -0x47aa);             /* call 0x100a4e00 */
            ii(0x100a_95aa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_95ad, 5); call(0x1014_85ad, 0x9_effb);            /* call 0x101485ad */
            ii(0x100a_95b2, 6); add(memd[ds, 0x101c_31bc], eax);        /* add [0x101c31bc], eax */
        l_0x100a_95b8:
            ii(0x100a_95b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_95ba, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_95bb, 1); pop(edi);                               /* pop edi */
            ii(0x100a_95bc, 1); pop(esi);                               /* pop esi */
            ii(0x100a_95bd, 1); pop(edx);                               /* pop edx */
            ii(0x100a_95be, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_95bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_95c0, 1); ret();                                  /* ret */
        }
    }
}
