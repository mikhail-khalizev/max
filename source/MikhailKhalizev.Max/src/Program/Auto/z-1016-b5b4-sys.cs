using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b5b4-3dbe44f3")]
        public void /* sys */ Method_1016_b5b4()
        {
            ii(0x1016_b5b4, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_b5b5, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_b5b6, 1);  push(edx);                            /* push edx */
            ii(0x1016_b5b7, 1);  push(esi);                            /* push esi */
            ii(0x1016_b5b8, 1);  push(edi);                            /* push edi */
            ii(0x1016_b5b9, 5);  mov(eax, memd[ds, 0x1020_88e8]);      /* mov eax, [0x102088e8] */
            ii(0x1016_b5be, 6);  sub(eax, memd[ds, 0x1020_88e0]);      /* sub eax, [0x102088e0] */
            ii(0x1016_b5c4, 3);  lea(esi, memd[ds, eax + 1]);          /* lea esi, [eax+0x1] */
            ii(0x1016_b5c7, 6);  mov(ebx, memd[ds, 0x1020_88e4]);      /* mov ebx, [0x102088e4] */
            ii(0x1016_b5cd, 5);  mov(eax, memd[ds, 0x1020_88ec]);      /* mov eax, [0x102088ec] */
            ii(0x1016_b5d2, 2);  sub(eax, ebx);                        /* sub eax, ebx */
            ii(0x1016_b5d4, 3);  lea(edx, memd[ds, eax + 1]);          /* lea edx, [eax+0x1] */
            ii(0x1016_b5d7, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_b5d9, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1016_b5dc, 5);  call(Definitions.sys_malloc_internal, 0x1_6d0f);/* call 0x101822f0 */
            ii(0x1016_b5e1, 5);  mov(memd[ds, 0x101c_fb70], eax);      /* mov [0x101cfb70], eax */
            ii(0x1016_b5e6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_b5e8, 2);  if(jz(0x1016_b63c, 0x52)) goto l_0x1016_b63c;/* jz 0x1016b63c */
            ii(0x1016_b5ea, 5);  mov(edi, /* sys */ 0x1016_b644);      /* mov edi, 0x1016b644 */
            ii(0x1016_b5ef, 5);  mov(eax, 0x1020_88e0);                /* mov eax, 0x102088e0 */
            ii(0x1016_b5f4, 6);  mov(ebx, memd[ds, 0x1020_892c]);      /* mov ebx, [0x1020892c] */
            ii(0x1016_b5fa, 6);  mov(ecx, memd[ds, 0x101c_fc00]);      /* mov ecx, [0x101cfc00] */
            ii(0x1016_b600, 6);  mov(memd[ds, 0x1020_892c], edi);      /* mov [0x1020892c], edi */
            ii(0x1016_b606, 6);  mov(memd[ds, 0x101c_fc00], edi);      /* mov [0x101cfc00], edi */
            ii(0x1016_b60c, 5);  call(/* sys */ 0x1016_7ac0, -0x3b51); /* call 0x10167ac0 */
            ii(0x1016_b611, 6);  mov(memd[ds, 0x101c_fc00], ecx);      /* mov [0x101cfc00], ecx */
            ii(0x1016_b617, 6);  mov(memd[ds, 0x1020_892c], ebx);      /* mov [0x1020892c], ebx */
            ii(0x1016_b61d, 5);  call(/* sys */ 0x1016_cc1c, 0x15fa);  /* call 0x1016cc1c */
            ii(0x1016_b622, 6);  mov(ebx, memd[ds, 0x101c_fb70]);      /* mov ebx, [0x101cfb70] */
            ii(0x1016_b628, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1016_b62a, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_b62c, 6);  call_abs(memd[ds, 0x101c_fb68]);      /* call dword [0x101cfb68] */
            ii(0x1016_b632, 5);  mov(eax, memd[ds, 0x101c_fb70]);      /* mov eax, [0x101cfb70] */
            ii(0x1016_b637, 5);  call(Definitions.sys_free_internal, 0x1_6e18);/* call 0x10182454 */
        l_0x1016_b63c:
            ii(0x1016_b63c, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_b63d, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_b63e, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_b63f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_b640, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_b641, 1);  ret();                                /* ret */
        }
    }
}
