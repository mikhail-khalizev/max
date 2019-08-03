using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89f93585-f174-46be-b17c-6ea147615d55")]
        public void Method_100a_96db()
        {
            ii(0x100a_96db, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_96e0, 5); calld(Definitions.sys_check_available_stack_size, 0xbc66d); /* call 0x10165d52 */
            ii(0x100a_96e5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_96e6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_96e7, 1); pushd(edx);                             /* push edx */
            ii(0x100a_96e8, 1); pushd(esi);                             /* push esi */
            ii(0x100a_96e9, 1); pushd(edi);                             /* push edi */
            ii(0x100a_96ea, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_96eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_96ed, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_96f3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_96f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_96f9, 4); inc(memw_a32[ds, eax + 0x8]);           /* inc word [eax+0x8] */
            ii(0x100a_96fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9700, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x100a_9704, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9707, 4); cmp(dx, memw_a32[ds, eax + 0xc]);       /* cmp dx, [eax+0xc] */
            ii(0x100a_970b, 2); if(jled(0x100a_9732, 0x25)) goto l_0x100a_9732; /* jle 0x100a9732 */
            ii(0x100a_970d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9710, 4); inc(memw_a32[ds, eax + 0xa]);           /* inc word [eax+0xa] */
            ii(0x100a_9714, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9717, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x100a_971b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_971e, 4); cmp(dx, memw_a32[ds, eax + 0xe]);       /* cmp dx, [eax+0xe] */
            ii(0x100a_9722, 2); if(jled(0x100a_972a, 0x6)) goto l_0x100a_972a; /* jle 0x100a972a */
            ii(0x100a_9724, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_9728, 2); jmpd(0x100a_9736, 0xc); goto l_0x100a_9736; /* jmp 0x100a9736 */
        l_0x100a_972a:
            ii(0x100a_972a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_972d, 5); calld(0x100a_9742, 0x10);               /* call 0x100a9742 */
        l_0x100a_9732:
            ii(0x100a_9732, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100a_9736:
            ii(0x100a_9736, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_9739, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_973b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_973c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_973d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_973e, 1); popd(edx);                              /* pop edx */
            ii(0x100a_973f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_9740, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_9741, 1); retd(); return;                         /* ret */
        }
    }
}