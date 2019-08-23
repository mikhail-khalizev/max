using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ef19-6e93fb43")]
        public void Method_100d_ef19()
        {
            ii(0x100d_ef19, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_ef1e, 5); call(Definitions.sys_check_available_stack_size, 0x8_6e2f); /* call 0x10165d52 */
            ii(0x100d_ef23, 1); push(ebx);                              /* push ebx */
            ii(0x100d_ef24, 1); push(ecx);                              /* push ecx */
            ii(0x100d_ef25, 1); push(esi);                              /* push esi */
            ii(0x100d_ef26, 1); push(edi);                              /* push edi */
            ii(0x100d_ef27, 1); push(ebp);                              /* push ebp */
            ii(0x100d_ef28, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_ef2a, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_ef30, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_ef33, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_ef36, 5); call(0x100e_0ab0, 0x1b75);              /* call 0x100e0ab0 */
            ii(0x100d_ef3b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_ef3d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ef40, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_ef43, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_ef46, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100d_ef48, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_ef4b, 2); call_abs(memd[ds, edx]);                /* call dword [edx] */
            ii(0x100d_ef4d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_ef4f, 5); call(0x100d_504c, -0x9f08);             /* call 0x100d504c */
            ii(0x100d_ef54, 2); test(al, al);                           /* test al, al */
            ii(0x100d_ef56, 2); if(jz(0x100d_efce, 0x76)) goto l_0x100d_efce; /* jz 0x100defce */
            ii(0x100d_ef58, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ef5b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_ef5e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_ef61, 5); call(0x100e_0a7c, 0x1b16);              /* call 0x100e0a7c */
            ii(0x100d_ef66, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_ef68, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_ef6b, 5); call(0x100e_0a44, 0x1ad4);              /* call 0x100e0a44 */
            ii(0x100d_ef70, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_ef72, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ef75, 4); add(memw[ds, eax + 0x4f], dx);          /* add [eax+0x4f], dx */
            ii(0x100d_ef79, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_ef7c, 5); call(0x100e_0a44, 0x1ac3);              /* call 0x100e0a44 */
            ii(0x100d_ef81, 3); imul(ebx, eax, 0x5);                    /* imul ebx, eax, 0x5 */
            ii(0x100d_ef84, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ef87, 6); mov(eax, memd[ds, eax + 0x3bb]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_ef8d, 5); call(0x100d_5018, -0x9f7a);             /* call 0x100d5018 */
            ii(0x100d_ef92, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_ef95, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ef98, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_ef9d, 5); call(0x100e_08bc, 0x191a);              /* call 0x100e08bc */
            ii(0x100d_efa2, 3); mov(memw[ds, eax], bx);                 /* mov [eax], bx */
            ii(0x100d_efa5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_efa8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_efab, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_efae, 3); mov(ebx, memd[ds, eax + 0x13]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_efb1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_efb4, 6); mov(eax, memd[ds, eax + 0x3bb]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_efba, 5); call(0x100d_0149, -0xee76);             /* call 0x100d0149 */
            ii(0x100d_efbf, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_efc2, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_efc5, 3); call_abs(memd[ds, ebx + 0x18]);         /* call dword [ebx+0x18] */
            ii(0x100d_efc8, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_efcc, 2); jmp(0x100d_efdc, 0xe); goto l_0x100d_efdc; /* jmp 0x100defdc */
        l_0x100d_efce:
            ii(0x100d_efce, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_efd1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_efd4, 5); call(0x100d_ab7d, -0x445c);             /* call 0x100dab7d */
            ii(0x100d_efd9, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x100d_efdc:
            ii(0x100d_efdc, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_efdf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_efe1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_efe2, 1); pop(edi);                               /* pop edi */
            ii(0x100d_efe3, 1); pop(esi);                               /* pop esi */
            ii(0x100d_efe4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_efe5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_efe6, 1); ret();                                  /* ret */
        }
    }
}
