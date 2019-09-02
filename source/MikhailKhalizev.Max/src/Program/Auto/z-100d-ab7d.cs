using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ab7d-d16a9f98")]
        public void Method_100d_ab7d()
        {
            ii(0x100d_ab7d, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_ab82, 5); call(Definitions.sys_check_available_stack_size, 0x8_b1cb); /* call 0x10165d52 */
            ii(0x100d_ab87, 1); push(ebx);                              /* push ebx */
            ii(0x100d_ab88, 1); push(ecx);                              /* push ecx */
            ii(0x100d_ab89, 1); push(esi);                              /* push esi */
            ii(0x100d_ab8a, 1); push(edi);                              /* push edi */
            ii(0x100d_ab8b, 1); push(ebp);                              /* push ebp */
            ii(0x100d_ab8c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_ab8e, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_ab94, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_ab97, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_ab9a, 5); call(0x100d_4fec, -0x5bb3);             /* call 0x100d4fec */
            ii(0x100d_ab9f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_aba1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_aba4, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100d_aba7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_abaa, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100d_abac, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_abaf, 2); call_abs(memd[ds, edx]);                /* call dword [edx] */
            ii(0x100d_abb1, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_abb3, 5); call(0x100d_504c, -0x5b6c);             /* call 0x100d504c */
            ii(0x100d_abb8, 2); test(al, al);                           /* test al, al */
            ii(0x100d_abba, 2); if(jz(0x100d_abf1, 0x35)) goto l_0x100d_abf1; /* jz 0x100dabf1 */
            ii(0x100d_abbc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_abbf, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100d_abc2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_abc5, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100d_abc8, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100d_abcb, 3); mov(esi, memd[ds, eax + 19]);           /* mov esi, [eax+0x13] */
            ii(0x100d_abce, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100d_abd1, 5); call(0x100d_4f8c, -0x5c4a);             /* call 0x100d4f8c */
            ii(0x100d_abd6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_abd8, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_abda, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100d_abdd, 5); call(0x100d_4fbc, -0x5c26);             /* call 0x100d4fbc */
            ii(0x100d_abe2, 3); mov(ecx, memd[ss, ebp - 24]);           /* mov ecx, [ebp-0x18] */
            ii(0x100d_abe5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_abe7, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100d_abe9, 3); call_abs(memd[ds, esi + 16]);           /* call dword [esi+0x10] */
            ii(0x100d_abec, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x100d_abef, 2); jmp(0x100d_abf5, 4); goto l_0x100d_abf5; /* jmp 0x100dabf5 */
        l_0x100d_abf1:
            ii(0x100d_abf1, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
        l_0x100d_abf5:
            ii(0x100d_abf5, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100d_abf8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_abfa, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_abfb, 1); pop(edi);                               /* pop edi */
            ii(0x100d_abfc, 1); pop(esi);                               /* pop esi */
            ii(0x100d_abfd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_abfe, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_abff, 1); ret();                                  /* ret */
        }
    }
}
