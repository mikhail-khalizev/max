using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2b0fbed2-03be-43c8-bd74-2b6291758363")]
        public void /* sys */ Method_1019_5353()
        {
            ii(0x1019_5353, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_5354, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_5356, 1); pushd(esi);                             /* push esi */
            ii(0x1019_5357, 1); pushd(edi);                             /* push edi */
            ii(0x1019_5358, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_5359, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_535a, 2); pushd(fs);                              /* push fs */
            ii(0x1019_535c, 2); pushd(gs);                              /* push gs */
            ii(0x1019_535e, 1); pushd(es);                              /* push es */
            ii(0x1019_535f, 5); mov(esi, 0x101c_1afc);                  /* mov esi, 0x101c1afc */
            ii(0x1019_5364, 7); mov(memd_a32[ds, esi + 0x1c], 0x8107);  /* mov dword [esi+0x1c], 0x8107 */
            ii(0x1019_536b, 7); mov(memd_a32[ds, esi + 0x14], 0);       /* mov dword [esi+0x14], 0x0 */
            ii(0x1019_5372, 4); mov(ax, memw_a32[ss, ebp + 0x8]);       /* mov ax, [ebp+0x8] */
            ii(0x1019_5376, 4); mov(memw_a32[ds, esi + 0x22], ax);      /* mov [esi+0x22], ax */
            ii(0x1019_537a, 6); mov(memd_a32[ds, esi], 0);              /* mov dword [esi], 0x0 */
            ii(0x1019_5380, 4); mov(ax, 0x300);                         /* mov ax, 0x300 */
            ii(0x1019_5384, 2); mov(bl, 0x4b);                          /* mov bl, 0x4b */
            ii(0x1019_5386, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1019_5388, 4); mov(cx, 0);                             /* mov cx, 0x0 */
            ii(0x1019_538c, 5); mov(edi, 0x101c_1afc);                  /* mov edi, 0x101c1afc */
            ii(0x1019_5391, 1); pushd(ds);                              /* push ds */
            ii(0x1019_5392, 1); popd(es);                               /* pop es */
            ii(0x1019_5393, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_5395, 5); mov(esi, 0x101c_1afc);                  /* mov esi, 0x101c1afc */
            ii(0x1019_539a, 5); and(memw_a32[ds, esi + 0x20], 0x1);     /* and word [esi+0x20], 0x1 */
            ii(0x1019_539f, 2); if(jnzd(0x1019_53af, 0xe)) goto l_0x1019_53af; /* jnz 0x101953af */
            ii(0x1019_53a1, 1); nop();                                  /* nop */
            ii(0x1019_53a2, 1); nop();                                  /* nop */
            ii(0x1019_53a3, 1); nop();                                  /* nop */
            ii(0x1019_53a4, 1); nop();                                  /* nop */
            ii(0x1019_53a5, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_53aa, 2); jmpd(0x1019_53b4, 0x8); goto l_0x1019_53b4; /* jmp 0x101953b4 */
        //  ii(0x1019_53ac, 3); Недостижимый код.
l_0x1019_53af:
            ii(0x1019_53af, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1019_53b4:
            ii(0x1019_53b4, 1); popd(es);                               /* pop es */
            ii(0x1019_53b5, 2); popd(gs);                               /* pop gs */
            ii(0x1019_53b7, 2); popd(fs);                               /* pop fs */
            ii(0x1019_53b9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_53ba, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_53bb, 1); popd(edi);                              /* pop edi */
            ii(0x1019_53bc, 1); popd(esi);                              /* pop esi */
            ii(0x1019_53bd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_53be, 1); retd(); return;                         /* ret */
        }
    }
}