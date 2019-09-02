using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_beba-78eadb11")]
        public void Method_100f_beba()
        {
            ii(0x100f_beba, 4); cmp(memb[ss, ebp - 8], 4);              /* cmp byte [ebp-0x8], 0x4 */
            ii(0x100f_bebe, 2); if(jz(0x100f_bef6, 0x36)) goto l_0x100f_bef6; /* jz 0x100fbef6 */
            ii(0x100f_bec0, 5); call(0x100c_aa00, -0x3_14c5);           /* call 0x100caa00 */
            ii(0x100f_bec5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_beca, 1); push(eax);                              /* push eax */
            ii(0x100f_becb, 5); call(0x100c_aa20, -0x3_14b0);           /* call 0x100caa20 */
            ii(0x100f_bed0, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_bed2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_bed4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bed6, 5); mov(eax, StringDefinitions.NoticeProximityZonesOverlapSelectAgainOrClickInsideRedCircleToRemainAtCurrentLocation); /* mov eax, 0x101a28fd */
            ii(0x100f_bedb, 5); call(0x1011_5d23, 0x1_9e43);            /* call 0x10115d23 */
            ii(0x100f_bee0, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100f_bee3, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100f_bee6, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_bee9, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100f_beec, 4); mov(memb[ss, ebp - 8], 2);              /* mov byte [ebp-0x8], 0x2 */
            ii(0x100f_bef0, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100f_bef4, 2); jmp(0x100f_bf07, 0x11); goto l_0x100f_bf07; /* jmp 0x100fbf07 */
        l_0x100f_bef6:
            ii(0x100f_bef6, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_befa, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_bf01, 2); if(jnz(0x100f_bf07, 4)) goto l_0x100f_bf07; /* jnz 0x100fbf07 */
            ii(0x100f_bf03, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_bf07:
            ii(0x100f_bf07, 2); if(jmp_func(0x100f_bf4f, 0x46)) return; /* jmp 0x100fbf4f */
        }
    }
}
