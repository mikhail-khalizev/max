using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_65d8-116889dd")]
        public void Method_1013_65d8()
        {
            ii(0x1013_65d8, 5); push(0x7c);                             /* push 0x7c */
            ii(0x1013_65dd, 5); call(Definitions.sys_check_available_stack_size, 0x2_f770); /* call 0x10165d52 */
            ii(0x1013_65e2, 1); push(ebx);                              /* push ebx */
            ii(0x1013_65e3, 1); push(ecx);                              /* push ecx */
            ii(0x1013_65e4, 1); push(edx);                              /* push edx */
            ii(0x1013_65e5, 1); push(esi);                              /* push esi */
            ii(0x1013_65e6, 1); push(edi);                              /* push edi */
            ii(0x1013_65e7, 1); push(ebp);                              /* push ebp */
            ii(0x1013_65e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_65ea, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x1013_65f0, 5); mov(eax, 0x101b_d35c);                  /* mov eax, 0x101bd35c */
            ii(0x1013_65f5, 5); call(/* sys */ 0x1016_611f, 0x2_fb25);  /* call 0x1016611f */
            ii(0x1013_65fa, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_65ff, 5); mov(eax, 0x101c_7124);                  /* mov eax, 0x101c7124 */
            ii(0x1013_6604, 5); call(0x1014_5894, 0xf28b);              /* call 0x10145894 */
            ii(0x1013_6609, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x1013_660c, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1013_660f, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1013_6612, 10); mov(memd[ds, 0x101b_d364], 1);         /* mov dword [0x101bd364], 0x1 */
            ii(0x1013_661c, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1013_6621, 5); mov(eax, 0x101c_7140);                  /* mov eax, 0x101c7140 */
            ii(0x1013_6626, 5); call(0x1014_5894, 0xf269);              /* call 0x10145894 */
            ii(0x1013_662b, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1013_662e, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1013_6631, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_6634, 10); mov(memd[ds, 0x101b_d364], 2);         /* mov dword [0x101bd364], 0x2 */
            ii(0x1013_663e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_6643, 5); mov(eax, 0x101c_715c);                  /* mov eax, 0x101c715c */
            ii(0x1013_6648, 5); call(0x1014_5894, 0xf247);              /* call 0x10145894 */
            ii(0x1013_664d, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1013_6650, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1013_6653, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_6656, 10); mov(memd[ds, 0x101b_d364], 3);         /* mov dword [0x101bd364], 0x3 */
            ii(0x1013_6660, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_6665, 5); mov(eax, 0x101c_7178);                  /* mov eax, 0x101c7178 */
            ii(0x1013_666a, 5); call(0x1014_5894, 0xf225);              /* call 0x10145894 */
            ii(0x1013_666f, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1013_6672, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1013_6675, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_6678, 10); mov(memd[ds, 0x101b_d364], 4);         /* mov dword [0x101bd364], 0x4 */
            ii(0x1013_6682, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_6687, 5); mov(eax, 0x101c_7194);                  /* mov eax, 0x101c7194 */
            ii(0x1013_668c, 5); call(0x1014_5894, 0xf203);              /* call 0x10145894 */
            ii(0x1013_6691, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1013_6694, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1013_6697, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_669a, 10); mov(memd[ds, 0x101b_d364], 5);         /* mov dword [0x101bd364], 0x5 */
            ii(0x1013_66a4, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_66a9, 5); mov(eax, 0x101c_71b0);                  /* mov eax, 0x101c71b0 */
            ii(0x1013_66ae, 5); call(0x1014_5894, 0xf1e1);              /* call 0x10145894 */
            ii(0x1013_66b3, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1013_66b6, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1013_66b9, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_66bc, 10); mov(memd[ds, 0x101b_d364], 6);         /* mov dword [0x101bd364], 0x6 */
            ii(0x1013_66c6, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_66cb, 5); mov(eax, 0x101c_71cc);                  /* mov eax, 0x101c71cc */
            ii(0x1013_66d0, 5); call(0x1014_5894, 0xf1bf);              /* call 0x10145894 */
            ii(0x1013_66d5, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1013_66d8, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1013_66db, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_66de, 10); mov(memd[ds, 0x101b_d364], 7);         /* mov dword [0x101bd364], 0x7 */
            ii(0x1013_66e8, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1013_66ed, 5); mov(eax, 0x101c_71e8);                  /* mov eax, 0x101c71e8 */
            ii(0x1013_66f2, 5); call(0x1014_5894, 0xf19d);              /* call 0x10145894 */
            ii(0x1013_66f7, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1013_66fa, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1013_66fd, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_6700, 10); mov(memd[ds, 0x101b_d364], 8);         /* mov dword [0x101bd364], 0x8 */
            ii(0x1013_670a, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1013_670f, 5); mov(eax, 0x101c_7204);                  /* mov eax, 0x101c7204 */
            ii(0x1013_6714, 5); call(0x1014_5894, 0xf17b);              /* call 0x10145894 */
            ii(0x1013_6719, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1013_671c, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1013_671f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_6722, 10); mov(memd[ds, 0x101b_d364], 9);         /* mov dword [0x101bd364], 0x9 */
            ii(0x1013_672c, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_6731, 5); mov(eax, 0x101c_7220);                  /* mov eax, 0x101c7220 */
            ii(0x1013_6736, 5); call(0x1014_5894, 0xf159);              /* call 0x10145894 */
            ii(0x1013_673b, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1013_673e, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1013_6741, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_6744, 10); mov(memd[ds, 0x101b_d364], 0xa);       /* mov dword [0x101bd364], 0xa */
            ii(0x1013_674e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_6753, 5); mov(eax, 0x101c_723c);                  /* mov eax, 0x101c723c */
            ii(0x1013_6758, 5); call(0x1014_5894, 0xf137);              /* call 0x10145894 */
            ii(0x1013_675d, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1013_6760, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1013_6763, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_6766, 10); mov(memd[ds, 0x101b_d364], 0xb);       /* mov dword [0x101bd364], 0xb */
            ii(0x1013_6770, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_6775, 5); mov(eax, 0x101c_7258);                  /* mov eax, 0x101c7258 */
            ii(0x1013_677a, 5); call(0x1014_5894, 0xf115);              /* call 0x10145894 */
            ii(0x1013_677f, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1013_6782, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1013_6785, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_6788, 10); mov(memd[ds, 0x101b_d364], 0xc);       /* mov dword [0x101bd364], 0xc */
            ii(0x1013_6792, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6794, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_6795, 1); pop(edi);                               /* pop edi */
            ii(0x1013_6796, 1); pop(esi);                               /* pop esi */
            ii(0x1013_6797, 1); pop(edx);                               /* pop edx */
            ii(0x1013_6798, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_6799, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_679a, 1); ret();                                  /* ret */
        }
    }
}
