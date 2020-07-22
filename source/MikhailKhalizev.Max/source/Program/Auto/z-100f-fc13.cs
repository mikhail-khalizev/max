using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_fc13-2a0150a4")]
        public void Method_100f_fc13()
        {
            ii(0x100f_fc13, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100f_fc18, 5);  call(Definitions.sys_check_available_stack_size, 0x6_6135);/* call 0x10165d52 */
            ii(0x100f_fc1d, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_fc1e, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_fc1f, 1);  push(edx);                            /* push edx */
            ii(0x100f_fc20, 1);  push(esi);                            /* push esi */
            ii(0x100f_fc21, 1);  push(edi);                            /* push edi */
            ii(0x100f_fc22, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_fc23, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_fc25, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100f_fc2b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_fc2d, 5);  mov(al, memb[ds, 0x101c_3916]);       /* mov al, [0x101c3916] */
            ii(0x100f_fc32, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_fc34, 2);  if(jz(0x100f_fc9a, 0x64)) goto l_0x100f_fc9a;/* jz 0x100ffc9a */
            ii(0x100f_fc36, 5);  call(0x100f_a835, -0x5406);           /* call 0x100fa835 */
            ii(0x100f_fc3b, 5);  call(0x100d_51c4, -0x2_aa7c);         /* call 0x100d51c4 */
            ii(0x100f_fc40, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_fc42, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100f_fc44, 5);  mov(eax, memd[ds, 0x101c_393c]);      /* mov eax, [0x101c393c] */
            ii(0x100f_fc49, 5);  call(0x100c_fb06, -0x3_0148);         /* call 0x100cfb06 */
            ii(0x100f_fc4e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_fc55, 2);  jmp(0x100f_fc5d, 6); goto l_0x100f_fc5d;/* jmp 0x100ffc5d */
        l_0x100f_fc57:
            ii(0x100f_fc57, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_fc5a, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
        l_0x100f_fc5d:
            ii(0x100f_fc5d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_fc61, 3);  cmp(eax, 0x18);                       /* cmp eax, 0x18 */
            ii(0x100f_fc64, 2);  if(jae(0x100f_fc93, 0x2d)) goto l_0x100f_fc93;/* jae 0x100ffc93 */
            ii(0x100f_fc66, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_fc6a, 3);  imul(eax, eax, 0xe);                  /* imul eax, eax, 0xe */
            ii(0x100f_fc6d, 7);  cmp(memd[ds, eax + 0x101b_8753], 0);  /* cmp dword [eax+0x101b8753], 0x0 */
            ii(0x100f_fc74, 2);  if(jz(0x100f_fc91, 0x1b)) goto l_0x100f_fc91;/* jz 0x100ffc91 */
            ii(0x100f_fc76, 5);  call(0x100d_51c4, -0x2_aab7);         /* call 0x100d51c4 */
            ii(0x100f_fc7b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_fc7d, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100f_fc7f, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_fc83, 3);  imul(eax, eax, 0xe);                  /* imul eax, eax, 0xe */
            ii(0x100f_fc86, 6);  mov(eax, memd[ds, eax + 0x101b_8753]);/* mov eax, [eax+0x101b8753] */
            ii(0x100f_fc8c, 5);  call(0x100c_fb06, -0x3_018b);         /* call 0x100cfb06 */
        l_0x100f_fc91:
            ii(0x100f_fc91, 2);  jmp(0x100f_fc57, -0x3c); goto l_0x100f_fc57;/* jmp 0x100ffc57 */
        l_0x100f_fc93:
            ii(0x100f_fc93, 7);  mov(memb[ds, 0x101c_3916], 0);        /* mov byte [0x101c3916], 0x0 */
        l_0x100f_fc9a:
            ii(0x100f_fc9a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_fc9c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_fc9d, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_fc9e, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_fc9f, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_fca0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_fca1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_fca2, 1);  ret();                                /* ret */
        }
    }
}
