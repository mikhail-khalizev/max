using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3b0f-19d9408e")]
        public void /* sys */ Method_1019_3b0f()
        {
            ii(0x1019_3b0f, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_3b10, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_3b11, 5);  mov(eax, memd[ds, Definitions.video_bank_count_in_win]);/* mov eax, [0x10209c9c] */
            ii(0x1019_3b16, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
            ii(0x1019_3b19, 6);  sub(edi, memd[ds, Definitions.video_win_len]);/* sub edi, [0x10209ca0] */
            ii(0x1019_3b1f, 7);  cmp(memd[ds, 0x1020_9c90], 0);        /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_3b26, 2);  if(jz(0x1019_3b39, 0x11)) goto l_0x1019_3b39;/* jz 0x10193b39 */
            ii(0x1019_3b28, 2);  mov(bh, 0);                           /* mov bh, 0x0 */
            ii(0x1019_3b2a, 6);  mov(bl, memb[ds, 0x1020_9cb0]);       /* mov bl, [0x10209cb0] */
            ii(0x1019_3b30, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1019_3b33, 6);  call_abs(memd[ds, 0x1020_9c90]);      /* call dword [0x10209c90] */
        l_0x1019_3b39:
            ii(0x1019_3b39, 1);  pop(edx);                             /* pop edx */
            ii(0x1019_3b3a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_3b3b, 3);  mov(ecx, memd[ss, ebp + 20]);         /* mov ecx, [ebp+0x14] */
            ii(0x1019_3b3e, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1019_3b43, 2);  jmp(0x1019_3b4b, 6); goto l_0x1019_3b4b;/* jmp 0x10193b4b */
        l_0x1019_3b45:
            ii(0x1019_3b45, 3);  mov(dx, memw[ds, ebx]);               /* mov dx, [ebx] */
            ii(0x1019_3b48, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
        l_0x1019_3b4b:
            ii(0x1019_3b4b, 3);  add(dx, dx);                          /* add dx, dx */
            ii(0x1019_3b4e, 2);  if(jz(0x1019_3b45, -0xb)) goto l_0x1019_3b45;/* jz 0x10193b45 */
            ii(0x1019_3b50, 2);  if(jb(0x1019_3b6c, 0x1a)) goto l_0x1019_3b6c;/* jb 0x10193b6c */
            ii(0x1019_3b52, 3);  add(esi, 8);                          /* add esi, 0x8 */
            ii(0x1019_3b55, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1019_3b58, 2);  if(loop(0x1019_3b4b, -0xf)) goto l_0x1019_3b4b;/* loop 0x10193b4b */
            ii(0x1019_3b5a, 5);  if(jmp_func(0x1019_394d, -0x212)) return;/* jmp 0x1019394d */
        l_0x1019_3b5f:
            ii(0x1019_3b5f, 3);  mov(dx, memw[ds, ebx]);               /* mov dx, [ebx] */
            ii(0x1019_3b62, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
        l_0x1019_3b65:
            ii(0x1019_3b65, 3);  add(dx, dx);                          /* add dx, dx */
            ii(0x1019_3b68, 2);  if(ja(0x1019_3b7b, 0x11)) goto l_0x1019_3b7b;/* ja 0x10193b7b */
            ii(0x1019_3b6a, 2);  if(jz(0x1019_3b5f, -0xd)) goto l_0x1019_3b5f;/* jz 0x10193b5f */
        l_0x1019_3b6c:
            ii(0x1019_3b6c, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1019_3b6f, 2);  if(loop(0x1019_3b65, -0xc)) goto l_0x1019_3b65;/* loop 0x10193b65 */
            ii(0x1019_3b71, 5);  call(/* sys */ 0x1019_3b92, 0x1c);    /* call 0x10193b92 */
            ii(0x1019_3b76, 5);  if(jmp_func(0x1019_394d, -0x22e)) return;/* jmp 0x1019394d */
        l_0x1019_3b7b:
            ii(0x1019_3b7b, 5);  call(/* sys */ 0x1019_3b92, 0x12);    /* call 0x10193b92 */
            ii(0x1019_3b80, 3);  add(esi, 8);                          /* add esi, 0x8 */
            ii(0x1019_3b83, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1019_3b86, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1019_3b8b, 2);  if(loop(0x1019_3b4b, -0x42)) goto l_0x1019_3b4b;/* loop 0x10193b4b */
            ii(0x1019_3b8d, 5);  jmp_func(0x1019_394d, -0x245);        /* jmp 0x1019394d */
        }
    }
}
