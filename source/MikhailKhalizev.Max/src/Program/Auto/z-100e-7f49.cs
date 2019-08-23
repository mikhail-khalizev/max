using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7f49-3ba181b7")]
        public void Method_100e_7f49()
        {
            ii(0x100e_7f49, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100e_7f4e, 5); call(Definitions.sys_check_available_stack_size, 0x7_ddff); /* call 0x10165d52 */
            ii(0x100e_7f53, 1); push(ebx);                              /* push ebx */
            ii(0x100e_7f54, 1); push(ecx);                              /* push ecx */
            ii(0x100e_7f55, 1); push(esi);                              /* push esi */
            ii(0x100e_7f56, 1); push(edi);                              /* push edi */
            ii(0x100e_7f57, 1); push(ebp);                              /* push ebp */
            ii(0x100e_7f58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7f5a, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_7f60, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_7f63, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_7f66, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7f69, 5); call(0x100e_7ec8, -0xa6);               /* call 0x100e7ec8 */
            ii(0x100e_7f6e, 3); mov(edi, memd[ss, ebp - 0x8]);          /* mov edi, [ebp-0x8] */
            ii(0x100e_7f71, 3); lea(edi, edi + 0x4);                    /* lea edi, [edi+0x4] */
            ii(0x100e_7f74, 3); mov(esi, memd[ss, ebp - 0x4]);          /* mov esi, [ebp-0x4] */
            ii(0x100e_7f77, 1); movsd();                                /* movsd */
            ii(0x100e_7f78, 1); movsd();                                /* movsd */
            ii(0x100e_7f79, 1); movsd();                                /* movsd */
            ii(0x100e_7f7a, 1); movsd();                                /* movsd */
            ii(0x100e_7f7b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7f7e, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100e_7f82, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_7f85, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x100e_7f89, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_7f8c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7f8f, 4); mov(ax, memw[ds, eax + 0x10]);          /* mov ax, [eax+0x10] */
            ii(0x100e_7f93, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_7f96, 4); sub(ax, memw[ds, edx + 0x8]);           /* sub ax, [edx+0x8] */
            ii(0x100e_7f9a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_7f9d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_7fa1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7fa4, 5); call(Definitions.sys_new_arr, 0x7_e067); /* call 0x10166010 */
            ii(0x100e_7fa9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_7fab, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7fae, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100e_7fb0, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_7fb7, 2); jmp(0x100e_7fbf, 0x6); goto l_0x100e_7fbf; /* jmp 0x100e7fbf */
        l_0x100e_7fb9:
            ii(0x100e_7fb9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_7fbc, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x100e_7fbf:
            ii(0x100e_7fbf, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_7fc2, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100e_7fc6, 2); if(jge(0x100e_8004, 0x3c)) goto l_0x100e_8004; /* jge 0x100e8004 */
            ii(0x100e_7fc8, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_7fcc, 5); call(Definitions.sys_new_arr, 0x7_e03f); /* call 0x10166010 */
            ii(0x100e_7fd1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_7fd3, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_7fd7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7fda, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_7fdc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7fdf, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_7fe1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_7fe3, 2); mov(memd[ds, eax], ebx);                /* mov [eax], ebx */
            ii(0x100e_7fe5, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_7fe9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_7feb, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_7fef, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7ff2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_7ff4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7ff7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_7ff9, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100e_7ffb, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_7ffd, 5); call(Definitions.sys_memset, 0x7_ddde); /* call 0x10165de0 */
            ii(0x100e_8002, 2); jmp(0x100e_7fb9, -0x4b); goto l_0x100e_7fb9; /* jmp 0x100e7fb9 */
        l_0x100e_8004:
            ii(0x100e_8004, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8006, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8007, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8008, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8009, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_800a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_800b, 1); ret();                                  /* ret */
        }
    }
}
