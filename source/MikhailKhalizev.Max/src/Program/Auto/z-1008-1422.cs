using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0135eb41-fb01-4ea5-8e1c-103773bf4356")]
        public void Method_1008_1422()
        {
            ii(0x1008_1422, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_1427, 5); calld(Definitions.sys_check_available_stack_size, 0xe_4926); /* call 0x10165d52 */
            ii(0x1008_142c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_142d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_142e, 1); pushd(edx);                             /* push edx */
            ii(0x1008_142f, 1); pushd(esi);                             /* push esi */
            ii(0x1008_1430, 1); pushd(edi);                             /* push edi */
            ii(0x1008_1431, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_1432, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_1434, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_143a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_143d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1440, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_1443, 5); calld(0x1007_6b90, -0xa8b8);            /* call 0x10076b90 */
            ii(0x1008_1448, 1); cwde();                                 /* cwde */
            ii(0x1008_1449, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_144b, 2); if(jnzd(0x1008_145e, 0x11)) goto l_0x1008_145e; /* jnz 0x1008145e */
            ii(0x1008_144d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1450, 4); mov(ax, memw_a32[ds, eax + 0xd]);       /* mov ax, [eax+0xd] */
            ii(0x1008_1454, 5); add(eax, 0xff);                         /* add eax, 0xff */
            ii(0x1008_1459, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_145c, 2); jmpd(0x1008_147d, 0x1f); goto l_0x1008_147d; /* jmp 0x1008147d */
        l_0x1008_145e:
            ii(0x1008_145e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1460, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1463, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_1466, 5); calld(0x1008_9c68, 0x87fd);             /* call 0x10089c68 */
            ii(0x1008_146b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_146e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_1471, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_1474, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_1477, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1008_147a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1008_147d:
            ii(0x1008_147d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_1480, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_1482, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_1483, 1); popd(edi);                              /* pop edi */
            ii(0x1008_1484, 1); popd(esi);                              /* pop esi */
            ii(0x1008_1485, 1); popd(edx);                              /* pop edx */
            ii(0x1008_1486, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_1487, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_1488, 1); retd(); return;                         /* ret */
        }
    }
}