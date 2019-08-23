using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_67e1-78e15789")]
        public void Method_1010_67e1()
        {
            ii(0x1010_67e1, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_67e6, 5); call(Definitions.sys_check_available_stack_size, 0x5_f567); /* call 0x10165d52 */
            ii(0x1010_67eb, 1); push(esi);                              /* push esi */
            ii(0x1010_67ec, 1); push(edi);                              /* push edi */
            ii(0x1010_67ed, 1); push(ebp);                              /* push ebp */
            ii(0x1010_67ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_67f0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_67f6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_67f9, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_67fc, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1010_67ff, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1010_6802, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_6806, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_6809, 6); push(memd[ds, eax + 0x101b_8fdc]);      /* push dword [eax+0x101b8fdc] */
            ii(0x1010_680f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_6812, 1); push(eax);                              /* push eax */
            ii(0x1010_6813, 5); call(0x1012_36fa, 0x1_cee2);            /* call 0x101236fa */
            ii(0x1010_6818, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_681b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_681d, 2); if(jz(0x1010_684e, 0x2f)) goto l_0x1010_684e; /* jz 0x1010684e */
            ii(0x1010_681f, 5); mov(eax, StringDefinitions.Text);       /* mov eax, 0x101a3b15 */
            ii(0x1010_6824, 1); push(eax);                              /* push eax */
            ii(0x1010_6825, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_6828, 1); push(eax);                              /* push eax */
            ii(0x1010_6829, 5); call(0x1012_3850, 0x1_d022);            /* call 0x10123850 */
            ii(0x1010_682e, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_6831, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6833, 2); if(jz(0x1010_684e, 0x19)) goto l_0x1010_684e; /* jz 0x1010684e */
            ii(0x1010_6835, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_6839, 1); push(eax);                              /* push eax */
            ii(0x1010_683a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_683d, 1); push(eax);                              /* push eax */
            ii(0x1010_683e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_6841, 1); push(eax);                              /* push eax */
            ii(0x1010_6842, 5); call(0x1012_3b6c, 0x1_d325);            /* call 0x10123b6c */
            ii(0x1010_6847, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_684a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_684c, 2); if(jnz(0x1010_685b, 0xd)) goto l_0x1010_685b; /* jnz 0x1010685b */
        l_0x1010_684e:
            ii(0x1010_684e, 5); mov(edx, StringDefinitions.NoClanChosenComputerWillChooseAClanAtRandom); /* mov edx, 0x101a3b1a */
            ii(0x1010_6853, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_6856, 5); call(Definitions.sys_strcpy, 0x5_f674); /* call 0x10165ecf */
        l_0x1010_685b:
            ii(0x1010_685b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_685d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_685e, 1); pop(edi);                               /* pop edi */
            ii(0x1010_685f, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6860, 1); ret();                                  /* ret */
        }
    }
}
