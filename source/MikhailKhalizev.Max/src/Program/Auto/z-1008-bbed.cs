using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_bbed-8454b718")]
        public void Method_1008_bbed()
        {
            ii(0x1008_bbed, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_bbf2, 5); call(Definitions.sys_check_available_stack_size, 0xd_a15b); /* call 0x10165d52 */
            ii(0x1008_bbf7, 1); push(ebx);                              /* push ebx */
            ii(0x1008_bbf8, 1); push(ecx);                              /* push ecx */
            ii(0x1008_bbf9, 1); push(edx);                              /* push edx */
            ii(0x1008_bbfa, 1); push(esi);                              /* push esi */
            ii(0x1008_bbfb, 1); push(edi);                              /* push edi */
            ii(0x1008_bbfc, 1); push(ebp);                              /* push ebp */
            ii(0x1008_bbfd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_bbff, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_bc05, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_bc08, 7); mov(dx, memw[ds, 0x101c_8172]);         /* mov dx, [0x101c8172] */
            ii(0x1008_bc0f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_bc12, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
            ii(0x1008_bc16, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1008_bc1b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bc1e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_bc21, 5); call(Definitions.sys_new_arr, 0xd_a3ea); /* call 0x10166010 */
            ii(0x1008_bc26, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_bc28, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_bc2b, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1008_bc2d, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_bc34, 2); jmp(0x1008_bc3c, 0x6); goto l_0x1008_bc3c; /* jmp 0x1008bc3c */
        l_0x1008_bc36:
            ii(0x1008_bc36, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_bc39, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x1008_bc3c:
            ii(0x1008_bc3c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_bc3f, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1008_bc46, 2); if(jge(0x1008_bc8d, 0x45)) goto l_0x1008_bc8d; /* jge 0x1008bc8d */
            ii(0x1008_bc48, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1008_bc4d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bc50, 5); call(Definitions.sys_new_arr, 0xd_a3bb); /* call 0x10166010 */
            ii(0x1008_bc55, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_bc57, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1008_bc5b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_bc5e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_bc60, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_bc63, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_bc65, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_bc67, 2); mov(memd[ds, eax], ebx);                /* mov [eax], ebx */
            ii(0x1008_bc69, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x1008_bc6f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_bc72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_bc74, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1008_bc78, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_bc7b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_bc7d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_bc80, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_bc82, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1008_bc84, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_bc86, 5); call(Definitions.sys_memset, 0xd_a155); /* call 0x10165de0 */
            ii(0x1008_bc8b, 2); jmp(0x1008_bc36, -0x57); goto l_0x1008_bc36; /* jmp 0x1008bc36 */
        l_0x1008_bc8d:
            ii(0x1008_bc8d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_bc90, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_bc93, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_bc96, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bc98, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_bc99, 1); pop(edi);                               /* pop edi */
            ii(0x1008_bc9a, 1); pop(esi);                               /* pop esi */
            ii(0x1008_bc9b, 1); pop(edx);                               /* pop edx */
            ii(0x1008_bc9c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_bc9d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_bc9e, 1); ret();                                  /* ret */
        }
    }
}
