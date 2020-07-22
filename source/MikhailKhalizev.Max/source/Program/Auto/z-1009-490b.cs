using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_490b-903fb48a")]
        public void Method_1009_490b()
        {
            ii(0x1009_490b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_4910, 5);  call(Definitions.sys_check_available_stack_size, 0xd_143d);/* call 0x10165d52 */
            ii(0x1009_4915, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_4916, 1);  push(esi);                            /* push esi */
            ii(0x1009_4917, 1);  push(edi);                            /* push edi */
            ii(0x1009_4918, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_4919, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_491b, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1009_4921, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_4924, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_4927, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_492a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_492d, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_4930, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_4933, 3);  neg(memd[ss, ebp - 16]);              /* neg dword [ebp-0x10] */
            ii(0x1009_4936, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_493a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_493c, 2);  if(jle(0x1009_4973, 0x35)) goto l_0x1009_4973;/* jle 0x10094973 */
            ii(0x1009_493e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_4941, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_4944, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x1009_4947, 2);  if(jle(0x1009_4952, 9)) goto l_0x1009_4952;/* jle 0x10094952 */
            ii(0x1009_4949, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_494c, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_494f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1009_4952:
            ii(0x1009_4952, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_4955, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1009_4959, 2);  if(jle(0x1009_4961, 6)) goto l_0x1009_4961;/* jle 0x10094961 */
            ii(0x1009_495b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_495e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1009_4961:
            ii(0x1009_4961, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_4964, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_4967, 3);  sub(memw[ds, edx], ax);               /* sub [edx], ax */
            ii(0x1009_496a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_496d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_4970, 3);  add(memw[ds, edx], ax);               /* add [edx], ax */
        l_0x1009_4973:
            ii(0x1009_4973, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_4975, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_4976, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_4977, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_4978, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_4979, 1);  ret();                                /* ret */
        }
    }
}
