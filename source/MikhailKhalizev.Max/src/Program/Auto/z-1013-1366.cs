using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1ab1c9c-b297-4a37-8f33-32dd0706aa36")]
        public void Method_1013_1366()
        {
            ii(0x1013_1366, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_136b, 5); calld(Definitions.sys_check_available_stack_size, 0x3_49e2); /* call 0x10165d52 */
            ii(0x1013_1370, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1371, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1372, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1373, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1374, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1375, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1377, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_137d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1380, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_1383, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1386, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_1389, 7); mov(memb_a32[ds, 0x101c_61b3], 0);      /* mov byte [0x101c61b3], 0x0 */
            ii(0x1013_1390, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1393, 5); calld(0x1012_f003, -0x2395);            /* call 0x1012f003 */
            ii(0x1013_1398, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_139b, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_139f, 2); if(jzd(0x1013_13aa, 0x9)) goto l_0x1013_13aa; /* jz 0x101313aa */
            ii(0x1013_13a1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_13a4, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_13a8, 2); if(jnzd(0x1013_13b7, 0xd)) goto l_0x1013_13b7; /* jnz 0x101313b7 */
        l_0x1013_13aa:
            ii(0x1013_13aa, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_13af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_13b2, 5); calld(0x1013_0c16, -0x7a1);             /* call 0x10130c16 */
        l_0x1013_13b7:
            ii(0x1013_13b7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_13b9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_13ba, 1); popd(edi);                              /* pop edi */
            ii(0x1013_13bb, 1); popd(esi);                              /* pop esi */
            ii(0x1013_13bc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_13bd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_13be, 1); retd(); return;                         /* ret */
        }
    }
}
