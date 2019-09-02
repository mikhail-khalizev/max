using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9840-631ca989")]
        public void Method_1015_9840()
        {
            ii(0x1015_9840, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1015_9845, 5); call(Definitions.sys_check_available_stack_size, 0xc508); /* call 0x10165d52 */
            ii(0x1015_984a, 1); push(ebx);                              /* push ebx */
            ii(0x1015_984b, 1); push(ecx);                              /* push ecx */
            ii(0x1015_984c, 1); push(esi);                              /* push esi */
            ii(0x1015_984d, 1); push(edi);                              /* push edi */
            ii(0x1015_984e, 1); push(ebp);                              /* push ebp */
            ii(0x1015_984f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9851, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_9857, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_985a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_985d, 5); mov(eax, 0x1015_97f2);                  /* mov eax, 0x101597f2 */
            ii(0x1015_9862, 1); push(eax);                              /* push eax */
            ii(0x1015_9863, 7); mov(memd[ss, ebp - 32], 0x31);          /* mov dword [ebp-0x20], 0x31 */
            ii(0x1015_986a, 5); mov(eax, StringDefinitions.Disable);    /* mov eax, 0x101b2630 */
            ii(0x1015_986f, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1015_9872, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_9875, 4); cmp(memb[ds, eax + 87], 9);             /* cmp byte [eax+0x57], 0x9 */
            ii(0x1015_9879, 2); if(jnz(0x1015_9881, 6)) goto l_0x1015_9881; /* jnz 0x10159881 */
            ii(0x1015_987b, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_987f, 2); jmp(0x1015_9885, 4); goto l_0x1015_9885; /* jmp 0x10159885 */
        l_0x1015_9881:
            ii(0x1015_9881, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_9885:
            ii(0x1015_9885, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9887, 3); mov(dl, memb[ss, ebp - 12]);            /* mov dl, [ebp-0xc] */
            ii(0x1015_988a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_988d, 3); mov(ecx, memd[ss, ebp - 32]);           /* mov ecx, [ebp-0x20] */
            ii(0x1015_9890, 3); mov(ebx, memd[ss, ebp - 28]);           /* mov ebx, [ebp-0x1c] */
            ii(0x1015_9893, 5); call(0x1015_7ccf, -0x1bc9);             /* call 0x10157ccf */
            ii(0x1015_9898, 5); mov(eax, 0x1015_97a4);                  /* mov eax, 0x101597a4 */
            ii(0x1015_989d, 1); push(eax);                              /* push eax */
            ii(0x1015_989e, 7); mov(memd[ss, ebp - 24], 0x32);          /* mov dword [ebp-0x18], 0x32 */
            ii(0x1015_98a5, 5); mov(eax, StringDefinitions.Steal);      /* mov eax, 0x101b2638 */
            ii(0x1015_98aa, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1015_98ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_98b0, 4); cmp(memb[ds, eax + 87], 8);             /* cmp byte [eax+0x57], 0x8 */
            ii(0x1015_98b4, 2); if(jnz(0x1015_98bc, 6)) goto l_0x1015_98bc; /* jnz 0x101598bc */
            ii(0x1015_98b6, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_98ba, 2); jmp(0x1015_98c0, 4); goto l_0x1015_98c0; /* jmp 0x101598c0 */
        l_0x1015_98bc:
            ii(0x1015_98bc, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_98c0:
            ii(0x1015_98c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_98c2, 3); mov(dl, memb[ss, ebp - 16]);            /* mov dl, [ebp-0x10] */
            ii(0x1015_98c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_98c8, 3); mov(ecx, memd[ss, ebp - 24]);           /* mov ecx, [ebp-0x18] */
            ii(0x1015_98cb, 3); mov(ebx, memd[ss, ebp - 20]);           /* mov ebx, [ebp-0x14] */
            ii(0x1015_98ce, 5); call(0x1015_7ccf, -0x1c04);             /* call 0x10157ccf */
            ii(0x1015_98d3, 5); mov(eax, 0x1015_8e5a);                  /* mov eax, 0x10158e5a */
            ii(0x1015_98d8, 1); push(eax);                              /* push eax */
            ii(0x1015_98d9, 5); mov(ecx, 0x33);                         /* mov ecx, 0x33 */
            ii(0x1015_98de, 5); mov(ebx, StringDefinitions.Attack3);    /* mov ebx, 0x101b263e */
            ii(0x1015_98e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_98e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_98e8, 3); mov(dl, memb[ds, eax + 85]);            /* mov dl, [eax+0x55] */
            ii(0x1015_98eb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_98ee, 5); call(0x1015_7ccf, -0x1c24);             /* call 0x10157ccf */
            ii(0x1015_98f3, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_98f6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_98f9, 5); call(0x1015_8bbb, -0xd43);              /* call 0x10158bbb */
            ii(0x1015_98fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9900, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_9901, 1); pop(edi);                               /* pop edi */
            ii(0x1015_9902, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9903, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9904, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9905, 1); ret();                                  /* ret */
        }
    }
}
