using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b330c6db-84c9-47e9-a81c-28f2a8e125a2")]
        public void /* sys */ Method_1019_4101()
        {
            ii(0x1019_4101, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4102, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4104, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4105, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4106, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1019_4109, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1019_410c, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1019_410f, 5); cmp(eax, 0x100);                        /* cmp eax, 0x100 */
            ii(0x1019_4114, 2); if(jbd(0x1019_411a, 0x4)) goto l_0x1019_411a; /* jb 0x1019411a */
            ii(0x1019_4116, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4117, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4118, 1); leaved();                               /* leave */
            ii(0x1019_4119, 1); retd(); return;                         /* ret */
        l_0x1019_411a:
            ii(0x1019_411a, 3); lea(ebx, ecx + eax);                    /* lea ebx, [ecx+eax] */
            ii(0x1019_411d, 6); cmp(ebx, 0x100);                        /* cmp ebx, 0x100 */
            ii(0x1019_4123, 2); if(jbed(0x1019_412c, 0x7)) goto l_0x1019_412c; /* jbe 0x1019412c */
            ii(0x1019_4125, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x1019_412a, 2); sub(ecx, eax);                          /* sub ecx, eax */
        l_0x1019_412c:
            ii(0x1019_412c, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_412e, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_4130, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_4132, 3); lea(ecx, ecx + ecx * 2);                /* lea ecx, [ecx+ecx*2] */
            ii(0x1019_4135, 5); mov(edx, 0x3c8);                        /* mov edx, 0x3c8 */
            ii(0x1019_413a, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_413b, 1); inc(edx);                               /* inc edx */
            ii(0x1019_413c, 2); rep_a32(() => outsb_a32());             /* rep outsb */
            ii(0x1019_413e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_413f, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4140, 1); leaved();                               /* leave */
            ii(0x1019_4141, 1); retd(); return;                         /* ret */
        }
    }
}
