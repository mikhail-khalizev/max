using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7b68-6de9d02c")]
        public void Method_100c_7b68()
        {
            ii(0x100c_7b68, 5); push(0x48);                             /* push 0x48 */
            ii(0x100c_7b6d, 5); call(Definitions.sys_check_available_stack_size, 0x9_e1e0); /* call 0x10165d52 */
            ii(0x100c_7b72, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7b73, 1); push(esi);                              /* push esi */
            ii(0x100c_7b74, 1); push(edi);                              /* push edi */
            ii(0x100c_7b75, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7b76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7b78, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_7b7e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_7b81, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100c_7b84, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100c_7b87, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100c_7b8c, 1); push(eax);                              /* push eax */
            ii(0x100c_7b8d, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100c_7b92, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_7b95, 1); push(eax);                              /* push eax */
            ii(0x100c_7b96, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x100c_7b9c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_7b9f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_7ba1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7ba3, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_7ba6, 5); call(0x1008_b148, -0x3_ca63);           /* call 0x1008b148 */
            ii(0x100c_7bab, 3); push(memd[ds, eax + 0xc]);              /* push dword [eax+0xc] */
            ii(0x100c_7bae, 3); push(memd[ds, eax + 8]);                /* push dword [eax+0x8] */
            ii(0x100c_7bb1, 3); push(memd[ds, eax + 4]);                /* push dword [eax+0x4] */
            ii(0x100c_7bb4, 2); push(memd[ds, eax]);                    /* push dword [eax] */
            ii(0x100c_7bb6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7bb9, 5); call(0x1009_02f8, -0x3_78c6);           /* call 0x100902f8 */
            ii(0x100c_7bbe, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_7bc1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7bc4, 7); mov(memd[ds, eax + 0x23], 0x101b_58ec); /* mov dword [eax+0x23], 0x101b58ec */
            ii(0x100c_7bcb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7bce, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_7bd1, 3); mov(memd[ds, edx + 0x27], eax);         /* mov [edx+0x27], eax */
            ii(0x100c_7bd4, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100c_7bd7, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_7bda, 3); mov(memb[ds, edx + 0x2b], al);          /* mov [edx+0x2b], al */
            ii(0x100c_7bdd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7be0, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_7be3, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_7be6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7be8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7be9, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7bea, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7beb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_7bec, 1); ret();                                  /* ret */
        }
    }
}
