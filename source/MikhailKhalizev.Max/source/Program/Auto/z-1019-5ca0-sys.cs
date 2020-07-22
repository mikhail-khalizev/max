using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5ca0-8c355a69")]
        public void /* sys */ Method_1019_5ca0()
        {
            ii(0x1019_5ca0, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1019_5ca2, 2);  if(jnz(0x1019_5ca9, 5)) goto l_0x1019_5ca9;/* jnz 0x10195ca9 */
            ii(0x1019_5ca4, 3);  mov(memd[ss, esp], ecx);              /* mov [esp], ecx */
            ii(0x1019_5ca7, 2);  jmp(0x1019_5cd4, 0x2b); goto l_0x1019_5cd4;/* jmp 0x10195cd4 */
        l_0x1019_5ca9:
            ii(0x1019_5ca9, 3);  cmp(ecx, memd[ds, esi + 9]);          /* cmp ecx, [esi+0x9] */
            ii(0x1019_5cac, 2);  if(jz(0x1019_5cd4, 0x26)) goto l_0x1019_5cd4;/* jz 0x10195cd4 */
            ii(0x1019_5cae, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1019_5cb0, 3);  mov(eax, memd[ds, edi + 4]);          /* mov eax, [edi+0x4] */
            ii(0x1019_5cb3, 5);  call(/* sys */ 0x1019_5c28, -0x90);   /* call 0x10195c28 */
            ii(0x1019_5cb8, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1019_5cbb, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1019_5cbe, 2);  if(jnz(0x1019_5cd4, 0x14)) goto l_0x1019_5cd4;/* jnz 0x10195cd4 */
            ii(0x1019_5cc0, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x1019_5cc3, 3);  mov(ax, memw[ds, ebx]);               /* mov ax, [ebx] */
            ii(0x1019_5cc6, 4);  cmp(ax, 1);                           /* cmp ax, 0x1 */
            ii(0x1019_5cca, 2);  if(jb(0x1019_5cd4, 8)) goto l_0x1019_5cd4;/* jb 0x10195cd4 */
            ii(0x1019_5ccc, 2);  if(jbe_func(0x1019_5ce4, 0x16)) return;/* jbe 0x10195ce4 */
            ii(0x1019_5cce, 4);  cmp(ax, 5);                           /* cmp ax, 0x5 */
            ii(0x1019_5cd2, 2);  if(jz_func(0x1019_5ce9, 0x15)) return;/* jz 0x10195ce9 */
        l_0x1019_5cd4:
            ii(0x1019_5cd4, 3);  mov(memd[ds, esi + 4], ecx);          /* mov [esi+0x4], ecx */
        }
    }
}
