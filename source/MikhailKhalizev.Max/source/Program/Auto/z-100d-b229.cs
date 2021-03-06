using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_b229-f25f012f")]
        public void Method_100d_b229()
        {
            ii(0x100d_b229, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100d_b22e, 5);  call(Definitions.sys_check_available_stack_size, 0x8_ab1f);/* call 0x10165d52 */
            ii(0x100d_b233, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_b234, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_b235, 1);  push(edx);                            /* push edx */
            ii(0x100d_b236, 1);  push(esi);                            /* push esi */
            ii(0x100d_b237, 1);  push(edi);                            /* push edi */
            ii(0x100d_b238, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_b239, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_b23b, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100d_b241, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_b244, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_b247, 6);  mov(eax, memd[ds, eax + 837]);        /* mov eax, [eax+0x345] */
            ii(0x100d_b24d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_b250, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_b253, 3);  mov(edx, memd[ds, eax + 64]);         /* mov edx, [eax+0x40] */
            ii(0x100d_b256, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_b259, 3);  call_abs(memd[ds, edx + 16]);         /* call dword [edx+0x10] */
            ii(0x100d_b25c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_b25f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_b262, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_b265, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_b268, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_b26b, 6);  mov(eax, memd[ds, eax + 837]);        /* mov eax, [eax+0x345] */
            ii(0x100d_b271, 5);  call(0x100d_0149, -0xb12d);           /* call 0x100d0149 */
            ii(0x100d_b276, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_b279, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_b27c, 3);  call_abs(memd[ds, ebx + 8]);          /* call dword [ebx+0x8] */
        l_0x100d_b27f:
            ii(0x100d_b27f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_b282, 7);  cmp(memb[ds, eax + 835], 0);          /* cmp byte [eax+0x343], 0x0 */
            ii(0x100d_b289, 2);  if(jnz(0x100d_b2c0, 0x35)) goto l_0x100d_b2c0;/* jnz 0x100db2c0 */
            ii(0x100d_b28b, 5);  call(/* sys */ 0x1016_b208, 0x8_ff78);/* call 0x1016b208 */
            ii(0x100d_b290, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_b293, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100d_b297, 2);  if(jle(0x100d_b2ae, 0x15)) goto l_0x100d_b2ae;/* jle 0x100db2ae */
            ii(0x100d_b299, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_b29c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_b29f, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_b2a2, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_b2a5, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_b2a8, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_b2ab, 3);  call_abs(memd[ds, ebx + 32]);         /* call dword [ebx+0x20] */
        l_0x100d_b2ae:
            ii(0x100d_b2ae, 5);  call(0x100d_5094, -0x621f);           /* call 0x100d5094 */
            ii(0x100d_b2b3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_b2b5, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_b2b7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_b2b9, 5);  call(0x1010_0e32, 0x2_5b74);          /* call 0x10100e32 */
            ii(0x100d_b2be, 2);  jmp(0x100d_b27f, -0x41); goto l_0x100d_b27f;/* jmp 0x100db27f */
        l_0x100d_b2c0:
            ii(0x100d_b2c0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_b2c3, 7);  cmp(memb[ds, eax + 836], 0);          /* cmp byte [eax+0x344], 0x0 */
            ii(0x100d_b2ca, 2);  if(jnz(0x100d_b2d5, 9)) goto l_0x100d_b2d5;/* jnz 0x100db2d5 */
            ii(0x100d_b2cc, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100d_b2d3, 2);  jmp(0x100d_b2dc, 7); goto l_0x100d_b2dc;/* jmp 0x100db2dc */
        l_0x100d_b2d5:
            ii(0x100d_b2d5, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100d_b2dc:
            ii(0x100d_b2dc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_b2df, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_b2e2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_b2e5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_b2e7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_b2e8, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_b2e9, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_b2ea, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_b2eb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_b2ec, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_b2ed, 1);  ret();                                /* ret */
        }
    }
}
