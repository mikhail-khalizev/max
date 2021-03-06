using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8096-9cc29a44")]
        public void Method_100c_8096()
        {
            ii(0x100c_8096, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_809b, 5);  call(Definitions.sys_check_available_stack_size, 0x9_dcb2);/* call 0x10165d52 */
            ii(0x100c_80a0, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_80a1, 1);  push(esi);                            /* push esi */
            ii(0x100c_80a2, 1);  push(edi);                            /* push edi */
            ii(0x100c_80a3, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_80a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_80a6, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100c_80ac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_80af, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_80b2, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_80b5, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_80b8, 5);  call(Definitions.my_ctor_0x101b_4184, -0x5_15cd);/* call 0x10076af0 */
        l_0x100c_80bd:
            ii(0x100c_80bd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_80c0, 3);  mov(edx, memd[ds, eax + 19]);         /* mov edx, [eax+0x13] */
            ii(0x100c_80c3, 3);  sub(edx, 4);                          /* sub edx, 0x4 */
            ii(0x100c_80c6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_80c9, 3);  sub(edx, memd[ds, eax + 11]);         /* sub edx, [eax+0xb] */
            ii(0x100c_80cc, 5);  call(/* sys */ 0x1016_5e9b, 0x9_ddca);/* call 0x10165e9b */
            ii(0x100c_80d1, 1);  inc(edx);                             /* inc edx */
            ii(0x100c_80d2, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100c_80d5, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_80d8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_80da, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_80dd, 3);  add(edx, memd[ds, eax + 11]);         /* add edx, [eax+0xb] */
            ii(0x100c_80e0, 4);  mov(memw[ss, ebp - 16], dx);          /* mov [ebp-0x10], dx */
            ii(0x100c_80e4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_80e7, 3);  mov(edx, memd[ds, eax + 23]);         /* mov edx, [eax+0x17] */
            ii(0x100c_80ea, 3);  sub(edx, 4);                          /* sub edx, 0x4 */
            ii(0x100c_80ed, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_80f0, 3);  sub(edx, memd[ds, eax + 15]);         /* sub edx, [eax+0xf] */
            ii(0x100c_80f3, 5);  call(/* sys */ 0x1016_5e9b, 0x9_dda3);/* call 0x10165e9b */
            ii(0x100c_80f8, 1);  inc(edx);                             /* inc edx */
            ii(0x100c_80f9, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100c_80fc, 3);  shr(edx, 0xf);                        /* shr edx, 0xf */
            ii(0x100c_80ff, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8102, 3);  add(edx, memd[ds, eax + 15]);         /* add edx, [eax+0xf] */
            ii(0x100c_8105, 4);  mov(memw[ss, ebp - 14], dx);          /* mov [ebp-0xe], dx */
            ii(0x100c_8109, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x100c_810c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_810f, 5);  call(0x1007_5e64, -0x5_22b0);         /* call 0x10075e64 */
            ii(0x100c_8114, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100c_8116, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_811a, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100c_811f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8122, 5);  call(0x100c_7f78, -0x1af);            /* call 0x100c7f78 */
            ii(0x100c_8127, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_8129, 2);  if(jz(0x100c_80bd, -0x6e)) goto l_0x100c_80bd;/* jz 0x100c80bd */
            ii(0x100c_812b, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_812f, 3);  imul(edx, edx, 0x13);                 /* imul edx, edx, 0x13 */
            ii(0x100c_8132, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_8135, 7);  mov(memw[ds, edx + 0x101c_35bc], ax); /* mov [edx+0x101c35bc], ax */
            ii(0x100c_813c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8140, 3);  imul(edx, edx, 0x13);                 /* imul edx, edx, 0x13 */
            ii(0x100c_8143, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x100c_8146, 7);  mov(memw[ds, edx + 0x101c_35be], ax); /* mov [edx+0x101c35be], ax */
            ii(0x100c_814d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_814f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_8150, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_8151, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_8152, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_8153, 1);  ret();                                /* ret */
        }
    }
}
