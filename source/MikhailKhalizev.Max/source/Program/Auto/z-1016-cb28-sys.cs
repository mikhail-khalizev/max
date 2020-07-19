using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_cb28-c4ad6424")]
        public void /* sys */ Method_1016_cb28()
        {
            ii(0x1016_cb28, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_cb29, 1);  push(esi);                            /* push esi */
            ii(0x1016_cb2a, 1);  push(edi);                            /* push edi */
            ii(0x1016_cb2b, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_cb2c, 6);  sub(esp, 0x30c);                      /* sub esp, 0x30c */
            ii(0x1016_cb32, 7);  mov(memd[ss, esp + 768], eax);        /* mov [esp+0x300], eax */
            ii(0x1016_cb39, 7);  mov(memd[ss, esp + 772], edx);        /* mov [esp+0x304], edx */
            ii(0x1016_cb40, 7);  mov(memd[ss, esp + 776], ebx);        /* mov [esp+0x308], ebx */
            ii(0x1016_cb47, 2);  xor(ebp, ebp);                        /* xor ebp, ebp */
            ii(0x1016_cb49, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_cb4b, 2);  if(jle(0x1016_cb9d, 0x50)) goto l_0x1016_cb9d;/* jle 0x1016cb9d */
        l_0x1016_cb4d:
            ii(0x1016_cb4d, 7);  mov(ecx, memd[ss, esp + 772]);        /* mov ecx, [esp+0x304] */
            ii(0x1016_cb54, 7);  mov(esi, memd[ss, esp + 768]);        /* mov esi, [esp+0x300] */
            ii(0x1016_cb5b, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
        l_0x1016_cb5d:
            ii(0x1016_cb5d, 3);  movzx(edi, memb[ds, esi]);            /* movzx edi, byte [esi] */
            ii(0x1016_cb60, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_cb62, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1016_cb64, 2);  mov(dl, memb[ds, ecx]);               /* mov dl, [ecx] */
            ii(0x1016_cb66, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_cb68, 3);  imul(eax, ebp);                       /* imul eax, ebp */
            ii(0x1016_cb6b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1016_cb6d, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1016_cb70, 7);  idiv(memd[ss, esp + 776]);            /* idiv dword [esp+0x308] */
            ii(0x1016_cb77, 1);  inc(ecx);                             /* inc ecx */
            ii(0x1016_cb78, 2);  sub(edi, eax);                        /* sub edi, eax */
            ii(0x1016_cb7a, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1016_cb7b, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1016_cb7d, 1);  inc(esi);                             /* inc esi */
            ii(0x1016_cb7e, 4);  mov(memb[ss, esp + ebx - 1], al);     /* mov [esp+ebx-0x1], al */
            ii(0x1016_cb82, 6);  cmp(ebx, 0x300);                      /* cmp ebx, 0x300 */
            ii(0x1016_cb88, 2);  if(jl(0x1016_cb5d, -0x2d)) goto l_0x1016_cb5d;/* jl 0x1016cb5d */
            ii(0x1016_cb8a, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1016_cb8c, 7);  mov(ebx, memd[ss, esp + 776]);        /* mov ebx, [esp+0x308] */
            ii(0x1016_cb93, 1);  inc(ebp);                             /* inc ebp */
            ii(0x1016_cb94, 5);  call(Definitions.sys_display_apply_palette, 0x23);/* call 0x1016cbbc */
            ii(0x1016_cb99, 2);  cmp(ebp, ebx);                        /* cmp ebp, ebx */
            ii(0x1016_cb9b, 2);  if(jl(0x1016_cb4d, -0x50)) goto l_0x1016_cb4d;/* jl 0x1016cb4d */
        l_0x1016_cb9d:
            ii(0x1016_cb9d, 7);  mov(eax, memd[ss, esp + 772]);        /* mov eax, [esp+0x304] */
            ii(0x1016_cba4, 5);  call(Definitions.sys_display_apply_palette, 0x13);/* call 0x1016cbbc */
            ii(0x1016_cba9, 6);  add(esp, 0x30c);                      /* add esp, 0x30c */
            ii(0x1016_cbaf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_cbb0, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_cbb1, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_cbb2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_cbb3, 1);  ret();                                /* ret */
        }
    }
}
