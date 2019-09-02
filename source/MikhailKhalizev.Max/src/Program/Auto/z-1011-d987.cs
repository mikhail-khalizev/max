using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d987-9aeb4d3c")]
        public void Method_1011_d987()
        {
            ii(0x1011_d987, 5); push(0x48);                             /* push 0x48 */
            ii(0x1011_d98c, 5); call(Definitions.sys_check_available_stack_size, 0x4_83c1); /* call 0x10165d52 */
            ii(0x1011_d991, 1); push(ebx);                              /* push ebx */
            ii(0x1011_d992, 1); push(ecx);                              /* push ecx */
            ii(0x1011_d993, 1); push(esi);                              /* push esi */
            ii(0x1011_d994, 1); push(edi);                              /* push edi */
            ii(0x1011_d995, 1); push(ebp);                              /* push ebp */
            ii(0x1011_d996, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d998, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_d99e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_d9a1, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_d9a4, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1011_d9a9, 1); push(eax);                              /* push eax */
            ii(0x1011_d9aa, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1011_d9af, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_d9b2, 1); push(eax);                              /* push eax */
            ii(0x1011_d9b3, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x1011_d9b9, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_d9bc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_d9be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_d9c0, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_d9c3, 5); call(0x1008_b148, -0x9_2880);           /* call 0x1008b148 */
            ii(0x1011_d9c8, 3); push(memd[ds, eax + 0xc]);              /* push dword [eax+0xc] */
            ii(0x1011_d9cb, 3); push(memd[ds, eax + 8]);                /* push dword [eax+0x8] */
            ii(0x1011_d9ce, 3); push(memd[ds, eax + 4]);                /* push dword [eax+0x4] */
            ii(0x1011_d9d1, 2); push(memd[ds, eax]);                    /* push dword [eax] */
            ii(0x1011_d9d3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_d9d6, 5); call(0x1009_02f8, -0x8_d6e3);           /* call 0x100902f8 */
            ii(0x1011_d9db, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_d9de, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_d9e1, 7); mov(memd[ds, eax + 0x23], 0x101b_68bc); /* mov dword [eax+0x23], 0x101b68bc */
            ii(0x1011_d9e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_d9eb, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_d9ee, 3); mov(memd[ds, edx + 0x27], eax);         /* mov [edx+0x27], eax */
            ii(0x1011_d9f1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_d9f4, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_d9f7, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_d9fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d9fc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_d9fd, 1); pop(edi);                               /* pop edi */
            ii(0x1011_d9fe, 1); pop(esi);                               /* pop esi */
            ii(0x1011_d9ff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_da00, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_da01, 1); ret();                                  /* ret */
        }
    }
}
