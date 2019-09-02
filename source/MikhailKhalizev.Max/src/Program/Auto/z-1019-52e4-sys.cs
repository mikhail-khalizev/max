using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_52e4-b9af234f")]
        public void /* sys */ Method_1019_52e4()
        {
            ii(0x1019_52e4, 1); push(ebp);                              /* push ebp */
            ii(0x1019_52e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_52e7, 1); push(esi);                              /* push esi */
            ii(0x1019_52e8, 1); push(edi);                              /* push edi */
            ii(0x1019_52e9, 1); push(ebx);                              /* push ebx */
            ii(0x1019_52ea, 1); push(ecx);                              /* push ecx */
            ii(0x1019_52eb, 2); pushd(fs);                              /* push fs */
            ii(0x1019_52ed, 2); pushd(gs);                              /* push gs */
            ii(0x1019_52ef, 1); pushd(es);                              /* push es */
            ii(0x1019_52f0, 4); mov(ax, 0x100);                         /* mov ax, 0x100 */
            ii(0x1019_52f4, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1019_52f7, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_52f9, 2); if(jae(0x1019_5309, 0xe)) goto l_0x1019_5309; /* jae 0x10195309 */
            ii(0x1019_52fb, 1); nop();                                  /* nop */
            ii(0x1019_52fc, 1); nop();                                  /* nop */
            ii(0x1019_52fd, 1); nop();                                  /* nop */
            ii(0x1019_52fe, 1); nop();                                  /* nop */
            ii(0x1019_52ff, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1019_5304, 2); jmp(0x1019_531a, 0x14); goto l_0x1019_531a; /* jmp 0x1019531a */
        //  ii(0x1019_5306, 1); nop();                                  /* nop */
        //  ii(0x1019_5307, 1); nop();                                  /* nop */
        //  ii(0x1019_5308, 1); nop();                                  /* nop */
        l_0x1019_5309:
            ii(0x1019_5309, 3); mov(esi, memd[ss, ebp + 0xc]);          /* mov esi, [ebp+0xc] */
            ii(0x1019_530c, 3); mov(memw[ds, esi], dx);                 /* mov [esi], dx */
            ii(0x1019_530f, 3); mov(esi, memd[ss, ebp + 0x10]);         /* mov esi, [ebp+0x10] */
            ii(0x1019_5312, 3); mov(memw[ds, esi], ax);                 /* mov [esi], ax */
            ii(0x1019_5315, 5); mov(eax, 0);                            /* mov eax, 0x0 */
        l_0x1019_531a:
            ii(0x1019_531a, 1); popd(es);                               /* pop es */
            ii(0x1019_531b, 2); popd(gs);                               /* pop gs */
            ii(0x1019_531d, 2); popd(fs);                               /* pop fs */
            ii(0x1019_531f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5320, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_5321, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5322, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5323, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_5324, 1); ret();                                  /* ret */
        }
    }
}
