using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4ebe-fbcfea64")]
        public void Method_100f_4ebe()
        {
            ii(0x100f_4ebe, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_4ec3, 5); call(Definitions.sys_check_available_stack_size, 0x7_0e8a); /* call 0x10165d52 */
            ii(0x100f_4ec8, 1); push(ebx);                              /* push ebx */
            ii(0x100f_4ec9, 1); push(ecx);                              /* push ecx */
            ii(0x100f_4eca, 1); push(esi);                              /* push esi */
            ii(0x100f_4ecb, 1); push(edi);                              /* push edi */
            ii(0x100f_4ecc, 1); push(ebp);                              /* push ebp */
            ii(0x100f_4ecd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4ecf, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_4ed5, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x100f_4ed8, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100f_4edb, 7); cmp(memb[ds, 0x101c_37d4], 0);          /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_4ee2, 2); if(jz(0x100f_4efa, 0x16)) goto l_0x100f_4efa; /* jz 0x100f4efa */
            ii(0x100f_4ee4, 5); mov(eax, 0x101c_37c4);                  /* mov eax, 0x101c37c4 */
            ii(0x100f_4ee9, 5); call(0x1007_6600, -0x7_e8ee);           /* call 0x10076600 */
            ii(0x100f_4eee, 5); call(0x1015_f2cc, 0x6_a3d9);            /* call 0x1015f2cc */
            ii(0x100f_4ef3, 7); mov(memb[ds, 0x101c_37d4], 0);          /* mov byte [0x101c37d4], 0x0 */
        l_0x100f_4efa:
            ii(0x100f_4efa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4efc, 5); call(0x100f_448c, -0xa75);              /* call 0x100f448c */
            ii(0x100f_4f01, 5); call(0x100f_40a6, -0xe60);              /* call 0x100f40a6 */
            ii(0x100f_4f06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4f08, 5); mov(eax, memd[ds, 0x101b_8753]);        /* mov eax, [0x101b8753] */
            ii(0x100f_4f0d, 5); call(0x100c_fb73, -0x2_539f);           /* call 0x100cfb73 */
            ii(0x100f_4f12, 5); call(0x100e_f348, -0x5bcf);             /* call 0x100ef348 */
            ii(0x100f_4f17, 1); cwde();                                 /* cwde */
            ii(0x100f_4f18, 5); call(0x100f_3499, -0x1a84);             /* call 0x100f3499 */
            ii(0x100f_4f1d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_4f20, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_4f25, 5); call(0x1012_0d94, 0x2_be6a);            /* call 0x10120d94 */
            ii(0x100f_4f2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4f2c, 3); mov(dl, memb[ss, ebp - 0x4]);           /* mov dl, [ebp-0x4] */
            ii(0x100f_4f2f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4f31, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100f_4f34, 5); call(0x1013_843f, 0x4_3506);            /* call 0x1013843f */
            ii(0x100f_4f39, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_4f3c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_4f3e, 3); mov(bl, memb[ss, ebp - 0x4]);           /* mov bl, [ebp-0x4] */
            ii(0x100f_4f41, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_4f44, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_4f48, 5); call(0x100f_39b4, -0x1599);             /* call 0x100f39b4 */
            ii(0x100f_4f4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4f4f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_4f50, 1); pop(edi);                               /* pop edi */
            ii(0x100f_4f51, 1); pop(esi);                               /* pop esi */
            ii(0x100f_4f52, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_4f53, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_4f54, 1); ret();                                  /* ret */
        }
    }
}
