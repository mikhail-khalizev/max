using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_140e-3fe6d573")]
        public void Method_100f_140e()
        {
            ii(0x100f_140e, 5); push(0x30);                             /* push 0x30 */
            ii(0x100f_1413, 5); call(Definitions.sys_check_available_stack_size, 0x7_493a); /* call 0x10165d52 */
            ii(0x100f_1418, 1); push(ebx);                              /* push ebx */
            ii(0x100f_1419, 1); push(ecx);                              /* push ecx */
            ii(0x100f_141a, 1); push(edx);                              /* push edx */
            ii(0x100f_141b, 1); push(esi);                              /* push esi */
            ii(0x100f_141c, 1); push(edi);                              /* push edi */
            ii(0x100f_141d, 1); push(ebp);                              /* push ebp */
            ii(0x100f_141e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1420, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_1426, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_1429, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_142c, 4); cmp(memd[ds, eax + 0x8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x100f_1430, 2); if(jz(0x100f_145c, 0x2a)) goto l_0x100f_145c; /* jz 0x100f145c */
            ii(0x100f_1432, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1435, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_1438, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_143b, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_143f, 2); if(jz(0x100f_1455, 0x14)) goto l_0x100f_1455; /* jz 0x100f1455 */
            ii(0x100f_1441, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_1443, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_1446, 5); call(Definitions.my_dtor_d3, -0x1_9718); /* call 0x100d7d33 */
            ii(0x100f_144b, 5); call(Definitions.sys_delete, 0x7_4b14); /* call 0x10165f64 */
            ii(0x100f_1450, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_1453, 2); jmp(0x100f_145c, 0x7); goto l_0x100f_145c; /* jmp 0x100f145c */
        l_0x100f_1455:
            ii(0x100f_1455, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x100f_145c:
            ii(0x100f_145c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_145f, 4); cmp(memd[ds, eax + 0xc], 0);            /* cmp dword [eax+0xc], 0x0 */
            ii(0x100f_1463, 2); if(jz(0x100f_148f, 0x2a)) goto l_0x100f_148f; /* jz 0x100f148f */
            ii(0x100f_1465, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1468, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100f_146b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_146e, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_1472, 2); if(jz(0x100f_1488, 0x14)) goto l_0x100f_1488; /* jz 0x100f1488 */
            ii(0x100f_1474, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_1476, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_1479, 5); call(Definitions.my_dtor_d3, -0x1_974b); /* call 0x100d7d33 */
            ii(0x100f_147e, 5); call(Definitions.sys_delete, 0x7_4ae1); /* call 0x10165f64 */
            ii(0x100f_1483, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_1486, 2); jmp(0x100f_148f, 0x7); goto l_0x100f_148f; /* jmp 0x100f148f */
        l_0x100f_1488:
            ii(0x100f_1488, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100f_148f:
            ii(0x100f_148f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1492, 7); mov(memd[ds, eax + 0x8], 0);            /* mov dword [eax+0x8], 0x0 */
            ii(0x100f_1499, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_149c, 7); mov(memd[ds, eax + 0xc], 0);            /* mov dword [eax+0xc], 0x0 */
            ii(0x100f_14a3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_14a6, 5); call(0x100f_1370, -0x13b);              /* call 0x100f1370 */
            ii(0x100f_14ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_14ad, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_14ae, 1); pop(edi);                               /* pop edi */
            ii(0x100f_14af, 1); pop(esi);                               /* pop esi */
            ii(0x100f_14b0, 1); pop(edx);                               /* pop edx */
            ii(0x100f_14b1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_14b2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_14b3, 1); ret();                                  /* ret */
        }
    }
}
