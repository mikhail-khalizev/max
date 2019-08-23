using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4540-1058974d")]
        public void /* sys */ Method_1019_4540()
        {
            ii(0x1019_4540, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4541, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4543, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4544, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4545, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1019_4548, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1019_454b, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_454d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1019_4550, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1019_4555, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_4557, 5); call(Definitions.sys_memset, -0x2_e77c); /* call 0x10165de0 */
            ii(0x1019_455c, 5); mov(edx, 0x300);                        /* mov edx, 0x300 */
            ii(0x1019_4561, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1019_4564, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1019_4566, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_4568, 4); mov(memw[ss, ebp - 0x34], dx);          /* mov [ebp-0x34], dx */
            ii(0x1019_456c, 3); mov(memb[ss, ebp - 0x30], al);          /* mov [ebp-0x30], al */
            ii(0x1019_456f, 3); mov(memb[ss, ebp - 0x2f], ah);          /* mov [ebp-0x2f], ah */
            ii(0x1019_4572, 4); mov(memw[ss, ebp - 0x2c], bx);          /* mov [ebp-0x2c], bx */
            ii(0x1019_4576, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1019_4578, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_457a, 3); lea(ebx, memd[ss, ebp - 0x34]);         /* lea ebx, [ebp-0x34] */
            ii(0x1019_457d, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1019_4582, 4); mov(memw[ss, ebp - 0x18], dx);          /* mov [ebp-0x18], dx */
            ii(0x1019_4586, 3); mov(memd[ss, ebp - 0x20], ecx);         /* mov [ebp-0x20], ecx */
            ii(0x1019_4589, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1019_458c, 3); lea(ecx, memd[ss, ebp - 0x18]);         /* lea ecx, [ebp-0x18] */
            ii(0x1019_458f, 5); call(/* sys */ 0x1016_c623, -0x2_7f71); /* call 0x1016c623 */
            ii(0x1019_4594, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1019_4598, 3); setz(al);                               /* setz al */
            ii(0x1019_459b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_45a0, 3); lea(esp, memd[ss, ebp - 0x8]);          /* lea esp, [ebp-0x8] */
            ii(0x1019_45a3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_45a4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_45a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_45a6, 1); ret();                                  /* ret */
        }
    }
}
