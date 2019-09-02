using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_09c2-ce5e4a9c")]
        public void Method_1009_09c2()
        {
            ii(0x1009_09c2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_09c7, 5); call(Definitions.sys_check_available_stack_size, 0xd_5386); /* call 0x10165d52 */
            ii(0x1009_09cc, 1); push(ecx);                              /* push ecx */
            ii(0x1009_09cd, 1); push(esi);                              /* push esi */
            ii(0x1009_09ce, 1); push(edi);                              /* push edi */
            ii(0x1009_09cf, 1); push(ebp);                              /* push ebp */
            ii(0x1009_09d0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_09d2, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_09d8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_09db, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_09de, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_09e1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_09e4, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_09e7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_09ea, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_09ec, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_09ef, 3); mov(edx, memd[ds, eax + 0x27]);         /* mov edx, [eax+0x27] */
            ii(0x1009_09f2, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1009_09f4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_09f7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_09f9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_09fc, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_09fe, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_0a00, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_0a02, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
        l_0x1009_0a05:
            ii(0x1009_0a05, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0a08, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x1009_0a0c, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1009_0a10, 2); if(jge(0x1009_0a1d, 0xb)) goto l_0x1009_0a1d; /* jge 0x10090a1d */
            ii(0x1009_0a12, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_0a15, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_0a18, 3); cmp(eax, 9);                            /* cmp eax, 0x9 */
            ii(0x1009_0a1b, 2); if(jnz(0x1009_0a1f, 2)) goto l_0x1009_0a1f; /* jnz 0x10090a1f */
        l_0x1009_0a1d:
            ii(0x1009_0a1d, 2); jmp(0x1009_0a2f, 0x10); goto l_0x1009_0a2f; /* jmp 0x10090a2f */
        l_0x1009_0a1f:
            ii(0x1009_0a1f, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_0a22, 4); add(memd[ss, ebp - 0x14], 2);           /* add dword [ebp-0x14], 0x2 */
            ii(0x1009_0a26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0a29, 4); inc(memw[ds, eax + 2]);                 /* inc word [eax+0x2] */
            ii(0x1009_0a2d, 2); jmp(0x1009_0a05, -0x2a); goto l_0x1009_0a05; /* jmp 0x10090a05 */
        l_0x1009_0a2f:
            ii(0x1009_0a2f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0a32, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x1009_0a36, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_0a39, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_0a3c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0a3e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_0a3f, 1); pop(edi);                               /* pop edi */
            ii(0x1009_0a40, 1); pop(esi);                               /* pop esi */
            ii(0x1009_0a41, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_0a42, 1); ret();                                  /* ret */
        }
    }
}
