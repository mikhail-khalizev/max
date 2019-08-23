using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_dfd1-129150aa")]
        public void Method_1010_dfd1()
        {
            ii(0x1010_dfd1, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_dfd6, 5); call(Definitions.sys_check_available_stack_size, 0x5_7d77); /* call 0x10165d52 */
            ii(0x1010_dfdb, 1); push(ecx);                              /* push ecx */
            ii(0x1010_dfdc, 1); push(esi);                              /* push esi */
            ii(0x1010_dfdd, 1); push(edi);                              /* push edi */
            ii(0x1010_dfde, 1); push(ebp);                              /* push ebp */
            ii(0x1010_dfdf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_dfe1, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_dfe7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_dfea, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_dfed, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1010_dff0, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1010_dff3, 2); add(al, 0x67);                          /* add al, 0x67 */
            ii(0x1010_dff5, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_dff8, 5); call(0x1007_5fdc, -0x9_8021);           /* call 0x10075fdc */
            ii(0x1010_dffd, 1); dec(eax);                               /* dec eax */
            ii(0x1010_dffe, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_e001, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_e005, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_e007, 2); if(jge(0x1010_e010, 0x7)) goto l_0x1010_e010; /* jge 0x1010e010 */
            ii(0x1010_e009, 7); mov(memd[ss, ebp - 0x10], 0x2);         /* mov dword [ebp-0x10], 0x2 */
        l_0x1010_e010:
            ii(0x1010_e010, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_e013, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_e016, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_e019, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_e01b, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1010_e01e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e020, 3); mov(dl, memb[ss, ebp - 0x4]);           /* mov dl, [ebp-0x4] */
            ii(0x1010_e023, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_e027, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_e02a, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1010_e02d, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1010_e030, 5); call(0x100c_fb73, -0x3_e4c2);           /* call 0x100cfb73 */
            ii(0x1010_e035, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e037, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_e038, 1); pop(edi);                               /* pop edi */
            ii(0x1010_e039, 1); pop(esi);                               /* pop esi */
            ii(0x1010_e03a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_e03b, 1); ret();                                  /* ret */
        }
    }
}
