using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9c9b-76310dc7")]
        public void Method_1015_9c9b()
        {
            ii(0x1015_9c9b, 5); push(0x38);                             /* push 0x38 */
            ii(0x1015_9ca0, 5); call(Definitions.sys_check_available_stack_size, 0xc0ad); /* call 0x10165d52 */
            ii(0x1015_9ca5, 1); push(ebx);                              /* push ebx */
            ii(0x1015_9ca6, 1); push(ecx);                              /* push ecx */
            ii(0x1015_9ca7, 1); push(esi);                              /* push esi */
            ii(0x1015_9ca8, 1); push(edi);                              /* push edi */
            ii(0x1015_9ca9, 1); push(ebp);                              /* push ebp */
            ii(0x1015_9caa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9cac, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1015_9cb2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9cb5, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9cb8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9cbb, 5); call(0x1014_1698, -0x1_8628);           /* call 0x10141698 */
            ii(0x1015_9cc0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_9cc3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9cc6, 4); cmp(memb[ds, eax + 0x3d], 0x8);         /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9cca, 2); if(jnz(0x1015_9cd5, 0x9)) goto l_0x1015_9cd5; /* jnz 0x10159cd5 */
            ii(0x1015_9ccc, 7); mov(memd[ss, ebp - 0x10], StringDefinitions.Start5); /* mov dword [ebp-0x10], 0x101b2670 */
            ii(0x1015_9cd3, 2); jmp(0x1015_9cdc, 0x7); goto l_0x1015_9cdc; /* jmp 0x10159cdc */
        l_0x1015_9cd5:
            ii(0x1015_9cd5, 7); mov(memd[ss, ebp - 0x10], StringDefinitions.Activate2); /* mov dword [ebp-0x10], 0x101b2676 */
        l_0x1015_9cdc:
            ii(0x1015_9cdc, 5); mov(eax, 0x1015_9be4);                  /* mov eax, 0x10159be4 */
            ii(0x1015_9ce1, 1); push(eax);                              /* push eax */
            ii(0x1015_9ce2, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1015_9ce7, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x1015_9cea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9cec, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9cef, 5); call(0x1015_7ccf, -0x2025);             /* call 0x10157ccf */
            ii(0x1015_9cf4, 5); mov(eax, 0x1015_9c4d);                  /* mov eax, 0x10159c4d */
            ii(0x1015_9cf9, 1); push(eax);                              /* push eax */
            ii(0x1015_9cfa, 7); mov(memd[ss, ebp - 0x1c], 0x32);        /* mov dword [ebp-0x1c], 0x32 */
            ii(0x1015_9d01, 5); mov(eax, StringDefinitions.Load2);      /* mov eax, 0x101b267f */
            ii(0x1015_9d06, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_9d09, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9d0c, 4); cmp(memb[ds, eax + 0x57], 0x7);         /* cmp byte [eax+0x57], 0x7 */
            ii(0x1015_9d10, 2); if(jnz(0x1015_9d18, 0x6)) goto l_0x1015_9d18; /* jnz 0x10159d18 */
            ii(0x1015_9d12, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1015_9d16, 2); jmp(0x1015_9d1c, 0x4); goto l_0x1015_9d1c; /* jmp 0x10159d1c */
        l_0x1015_9d18:
            ii(0x1015_9d18, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1015_9d1c:
            ii(0x1015_9d1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9d1e, 3); mov(dl, memb[ss, ebp - 0x14]);          /* mov dl, [ebp-0x14] */
            ii(0x1015_9d21, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9d24, 3); mov(ecx, memd[ss, ebp - 0x1c]);         /* mov ecx, [ebp-0x1c] */
            ii(0x1015_9d27, 3); mov(ebx, memd[ss, ebp - 0x18]);         /* mov ebx, [ebp-0x18] */
            ii(0x1015_9d2a, 5); call(0x1015_7ccf, -0x2060);             /* call 0x10157ccf */
            ii(0x1015_9d2f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9d32, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9d35, 5); call(0x1015_8bbb, -0x117f);             /* call 0x10158bbb */
            ii(0x1015_9d3a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9d3c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_9d3d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_9d3e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9d3f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9d40, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9d41, 1); ret();                                  /* ret */
        }
    }
}
