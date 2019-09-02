using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e171-47457a4c")]
        public void Method_1010_e171()
        {
            ii(0x1010_e171, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_e176, 5); call(Definitions.sys_check_available_stack_size, 0x5_7bd7); /* call 0x10165d52 */
            ii(0x1010_e17b, 1); push(ebx);                              /* push ebx */
            ii(0x1010_e17c, 1); push(ecx);                              /* push ecx */
            ii(0x1010_e17d, 1); push(edx);                              /* push edx */
            ii(0x1010_e17e, 1); push(esi);                              /* push esi */
            ii(0x1010_e17f, 1); push(edi);                              /* push edi */
            ii(0x1010_e180, 1); push(ebp);                              /* push ebp */
            ii(0x1010_e181, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e183, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_e189, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_e18c, 7); mov(memd[ss, ebp - 8], 0x13);           /* mov dword [ebp-0x8], 0x13 */
        l_0x1010_e193:
            ii(0x1010_e193, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1010_e196, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_e19b, 2); if(jz(0x1010_e1e0, 0x43)) goto l_0x1010_e1e0; /* jz 0x1010e1e0 */
            ii(0x1010_e19d, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_e1a1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_e1a4, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1010_e1a7, 4); cmp(memd[ds, eax + 0x14], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x1010_e1ab, 2); if(jz(0x1010_e1de, 0x31)) goto l_0x1010_e1de; /* jz 0x1010e1de */
            ii(0x1010_e1ad, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_e1b1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_e1b4, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1010_e1b7, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1010_e1ba, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_e1bd, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_e1c1, 2); if(jz(0x1010_e1d7, 0x14)) goto l_0x1010_e1d7; /* jz 0x1010e1d7 */
            ii(0x1010_e1c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e1c5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_e1c8, 5); call(Definitions.my_dtor_d2, -0x3_fc95); /* call 0x100ce538 */
            ii(0x1010_e1cd, 5); call(Definitions.sys_delete, 0x5_7d92); /* call 0x10165f64 */
            ii(0x1010_e1d2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_e1d5, 2); jmp(0x1010_e1de, 7); goto l_0x1010_e1de; /* jmp 0x1010e1de */
        l_0x1010_e1d7:
            ii(0x1010_e1d7, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_e1de:
            ii(0x1010_e1de, 2); jmp(0x1010_e193, -0x4d); goto l_0x1010_e193; /* jmp 0x1010e193 */
        l_0x1010_e1e0:
            ii(0x1010_e1e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e1e2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_e1e3, 1); pop(edi);                               /* pop edi */
            ii(0x1010_e1e4, 1); pop(esi);                               /* pop esi */
            ii(0x1010_e1e5, 1); pop(edx);                               /* pop edx */
            ii(0x1010_e1e6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_e1e7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_e1e8, 1); ret();                                  /* ret */
        }
    }
}
