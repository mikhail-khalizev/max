using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_53bf-a8ca854f")]
        public void /* sys */ Method_1019_53bf()
        {
            ii(0x1019_53bf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_53c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_53c2, 1); pushd(esi);                             /* push esi */
            ii(0x1019_53c3, 1); pushd(edi);                             /* push edi */
            ii(0x1019_53c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_53c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_53c6, 2); pushd(fs);                              /* push fs */
            ii(0x1019_53c8, 2); pushd(gs);                              /* push gs */
            ii(0x1019_53ca, 1); pushd(es);                              /* push es */
            ii(0x1019_53cb, 5); mov(esi, 0x101c_1afc);                  /* mov esi, 0x101c1afc */
            ii(0x1019_53d0, 7); mov(memd_a32[ds, esi + 0x1c], 0x8108);  /* mov dword [esi+0x1c], 0x8108 */
            ii(0x1019_53d7, 7); mov(memd_a32[ds, esi + 0x14], 0);       /* mov dword [esi+0x14], 0x0 */
            ii(0x1019_53de, 4); mov(ax, memw_a32[ss, ebp + 0x8]);       /* mov ax, [ebp+0x8] */
            ii(0x1019_53e2, 4); mov(memw_a32[ds, esi + 0x22], ax);      /* mov [esi+0x22], ax */
            ii(0x1019_53e6, 6); mov(memd_a32[ds, esi], 0);              /* mov dword [esi], 0x0 */
            ii(0x1019_53ec, 4); mov(ax, 0x300);                         /* mov ax, 0x300 */
            ii(0x1019_53f0, 2); mov(bl, 0x4b);                          /* mov bl, 0x4b */
            ii(0x1019_53f2, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1019_53f4, 4); mov(cx, 0);                             /* mov cx, 0x0 */
            ii(0x1019_53f8, 5); mov(edi, 0x101c_1afc);                  /* mov edi, 0x101c1afc */
            ii(0x1019_53fd, 1); pushd(ds);                              /* push ds */
            ii(0x1019_53fe, 1); popd(es);                               /* pop es */
            ii(0x1019_53ff, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_5401, 1); popd(es);                               /* pop es */
            ii(0x1019_5402, 2); popd(gs);                               /* pop gs */
            ii(0x1019_5404, 2); popd(fs);                               /* pop fs */
            ii(0x1019_5406, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5407, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5408, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5409, 1); popd(esi);                              /* pop esi */
            ii(0x1019_540a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_540b, 1); retd();                                 /* ret */
        }
    }
}
