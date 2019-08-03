using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83821078-ea63-43a5-bf7c-fe90fa0af232")]
        public void /* sys */ Method_1019_4950()
        {
            ii(0x1019_4950, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1019_4953, 2); if(jzd(0x1019_49af, 0x5a)) goto l_0x1019_49af; /* jz 0x101949af */
            ii(0x1019_4955, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4957, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1019_495c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1019_495f, 2); if(jnzd(0x1019_496a, 0x9)) goto l_0x1019_496a; /* jnz 0x1019496a */
            ii(0x1019_4961, 7); cmp(memb_a32[ds, 0x101b_e58f], 0);      /* cmp byte [0x101be58f], 0x0 */
            ii(0x1019_4968, 2); if(jzd(0x1019_4976, 0xc)) goto l_0x1019_4976; /* jz 0x10194976 */
        l_0x1019_496a:
            ii(0x1019_496a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_496c, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1019_4971, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1019_4974, 2); if(jnzd(0x1019_497a, 0x4)) goto l_0x1019_497a; /* jnz 0x1019497a */
        l_0x1019_4976:
            ii(0x1019_4976, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4978, 2); jmpd(0x1019_497f, 0x5); goto l_0x1019_497f; /* jmp 0x1019497f */
        l_0x1019_497a:
            ii(0x1019_497a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1019_497f:
            ii(0x1019_497f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_4981, 2); if(jzd(0x1019_49af, 0x2c)) goto l_0x1019_49af; /* jz 0x101949af */
            ii(0x1019_4983, 3); cmp(ecx, 0x2);                          /* cmp ecx, 0x2 */
            ii(0x1019_4986, 6); jnzd_func(0x1019_4799, -0x1f3);         /* jnz 0x10194799 */
            ii(0x1019_498c, 4); mov(dh, memb_a32[ss, esp + 0x4]);       /* mov dh, [esp+0x4] */
            ii(0x1019_4990, 3); test(dh, 0x1);                          /* test dh, 0x1 */
            ii(0x1019_4993, 2); if(jnzd(0x1019_49af, 0x1a)) goto l_0x1019_49af; /* jnz 0x101949af */
            ii(0x1019_4995, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1019_4998, 5); calld(/* sys */ 0x1018_6f1c, -0xda81);  /* call 0x10186f1c */
            ii(0x1019_499d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_499f, 2); if(jzd(0x1019_49af, 0xe)) goto l_0x1019_49af; /* jz 0x101949af */
            ii(0x1019_49a1, 2); mov(bl, dh);                            /* mov bl, dh */
            ii(0x1019_49a3, 3); or(bl, 0x1);                            /* or bl, 0x1 */
            ii(0x1019_49a6, 4); mov(memb_a32[ss, esp + 0x4], bl);       /* mov [esp+0x4], bl */
            ii(0x1019_49aa, 5); jmpd_func(0x1019_4799, -0x216); return; /* jmp 0x10194799 */
        l_0x1019_49af:
            ii(0x1019_49af, 2); xor(eax, eax);                          /* xor eax, eax */
        }
    }
}
