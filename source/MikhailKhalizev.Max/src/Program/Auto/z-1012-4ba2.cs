using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4ba2-a449a9df")]
        public void Method_1012_4ba2()
        {
            ii(0x1012_4ba2, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_4ba7, 5); call(Definitions.sys_check_available_stack_size, 0x4_11a6); /* call 0x10165d52 */
            ii(0x1012_4bac, 1); push(ebx);                              /* push ebx */
            ii(0x1012_4bad, 1); push(ecx);                              /* push ecx */
            ii(0x1012_4bae, 1); push(edx);                              /* push edx */
            ii(0x1012_4baf, 1); push(esi);                              /* push esi */
            ii(0x1012_4bb0, 1); push(edi);                              /* push edi */
            ii(0x1012_4bb1, 1); push(ebp);                              /* push ebp */
            ii(0x1012_4bb2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4bb4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_4bba, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1012_4bbe, 6); mov(edx, memd[ds, 0x101c_586c]);        /* mov edx, [0x101c586c] */
            ii(0x1012_4bc4, 5); mov(eax, memd[ds, 0x101c_5870]);        /* mov eax, [0x101c5870] */
            ii(0x1012_4bc9, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1012_4bcb, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1012_4bcd, 2); if(jz(0x1012_4c01, 0x32)) goto l_0x1012_4c01; /* jz 0x10124c01 */
            ii(0x1012_4bcf, 5); mov(eax, memd[ds, 0x101c_5870]);        /* mov eax, [0x101c5870] */
            ii(0x1012_4bd4, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1012_4bd6, 5); mov(eax, memd[ds, 0x101c_5870]);        /* mov eax, [0x101c5870] */
            ii(0x1012_4bdb, 2); inc(memd[ds, eax]);                     /* inc dword [eax] */
            ii(0x1012_4bdd, 5); mov(eax, memd[ds, 0x101c_5980]);        /* mov eax, [0x101c5980] */
            ii(0x1012_4be2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_4be4, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_4be6, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_4be9, 5); mov(eax, memd[ds, 0x101c_5870]);        /* mov eax, [0x101c5870] */
            ii(0x1012_4bee, 6); cmp(memd[ds, eax], 0x400);              /* cmp dword [eax], 0x400 */
            ii(0x1012_4bf4, 2); if(jnz(0x1012_4c01, 0xb)) goto l_0x1012_4c01; /* jnz 0x10124c01 */
            ii(0x1012_4bf6, 5); mov(eax, memd[ds, 0x101c_5870]);        /* mov eax, [0x101c5870] */
            ii(0x1012_4bfb, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
        l_0x1012_4c01:
            ii(0x1012_4c01, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_4c04, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x1012_4c07, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1012_4c0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4c0c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_4c0d, 1); pop(edi);                               /* pop edi */
            ii(0x1012_4c0e, 1); pop(esi);                               /* pop esi */
            ii(0x1012_4c0f, 1); pop(edx);                               /* pop edx */
            ii(0x1012_4c10, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_4c11, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_4c12, 1); ret();                                  /* ret */
        }
    }
}
