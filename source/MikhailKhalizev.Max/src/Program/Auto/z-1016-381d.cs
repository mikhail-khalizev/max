using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_381d-71397905")]
        public void Method_1016_381d()
        {
            ii(0x1016_381d, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_3822, 5); call(Definitions.sys_check_available_stack_size, 0x252b); /* call 0x10165d52 */
            ii(0x1016_3827, 1); push(ebx);                              /* push ebx */
            ii(0x1016_3828, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3829, 1); push(esi);                              /* push esi */
            ii(0x1016_382a, 1); push(edi);                              /* push edi */
            ii(0x1016_382b, 1); push(ebp);                              /* push ebp */
            ii(0x1016_382c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_382e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1016_3834, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_3837, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_383a, 5); mov(edx, StringDefinitions.Turns5);     /* mov edx, 0x101b2a19 */
            ii(0x1016_383f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3842, 5); call(0x1014_60aa, -0x1_d79d);           /* call 0x101460aa */
            ii(0x1016_3847, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_384a, 4); mov(memw[ds, edx + 8], ax);             /* mov [edx+0x8], ax */
            ii(0x1016_384e, 5); mov(edx, StringDefinitions.Hits7);      /* mov edx, 0x101b2a1f */
            ii(0x1016_3853, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3856, 5); call(0x1014_60aa, -0x1_d7b1);           /* call 0x101460aa */
            ii(0x1016_385b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_385e, 4); mov(memw[ds, edx + 10], ax);            /* mov [edx+0xa], ax */
            ii(0x1016_3862, 5); mov(edx, StringDefinitions.Armor2);     /* mov edx, 0x101b2a24 */
            ii(0x1016_3867, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_386a, 5); call(0x1014_60aa, -0x1_d7c5);           /* call 0x101460aa */
            ii(0x1016_386f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_3872, 4); mov(memw[ds, edx + 12], ax);            /* mov [edx+0xc], ax */
            ii(0x1016_3876, 5); mov(edx, StringDefinitions.Attack4);    /* mov edx, 0x101b2a2a */
            ii(0x1016_387b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_387e, 5); call(0x1014_60aa, -0x1_d7d9);           /* call 0x101460aa */
            ii(0x1016_3883, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_3886, 4); mov(memw[ds, edx + 14], ax);            /* mov [edx+0xe], ax */
            ii(0x1016_388a, 5); mov(edx, StringDefinitions.Speed6);     /* mov edx, 0x101b2a31 */
            ii(0x1016_388f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3892, 5); call(0x1014_60aa, -0x1_d7ed);           /* call 0x101460aa */
            ii(0x1016_3897, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_389a, 4); mov(memw[ds, edx + 16], ax);            /* mov [edx+0x10], ax */
            ii(0x1016_389e, 5); mov(edx, StringDefinitions.Range2);     /* mov edx, 0x101b2a37 */
            ii(0x1016_38a3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_38a6, 5); call(0x1014_60aa, -0x1_d801);           /* call 0x101460aa */
            ii(0x1016_38ab, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_38ae, 4); mov(memw[ds, edx + 18], ax);            /* mov [edx+0x12], ax */
            ii(0x1016_38b2, 5); mov(edx, StringDefinitions.Rounds);     /* mov edx, 0x101b2a3d */
            ii(0x1016_38b7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_38ba, 5); call(0x1014_60aa, -0x1_d815);           /* call 0x101460aa */
            ii(0x1016_38bf, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_38c2, 4); mov(memw[ds, edx + 20], ax);            /* mov [edx+0x14], ax */
            ii(0x1016_38c6, 5); mov(edx, StringDefinitions.MoveAndFire3); /* mov edx, 0x101b2a44 */
            ii(0x1016_38cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_38ce, 5); call(0x1014_5ff7, -0x1_d8dc);           /* call 0x10145ff7 */
            ii(0x1016_38d3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_38d6, 3); mov(memb[ds, edx + 22], al);            /* mov [edx+0x16], al */
            ii(0x1016_38d9, 5); mov(edx, StringDefinitions.Scan2);      /* mov edx, 0x101b2a52 */
            ii(0x1016_38de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_38e1, 5); call(0x1014_60aa, -0x1_d83c);           /* call 0x101460aa */
            ii(0x1016_38e6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_38e9, 4); mov(memw[ds, edx + 23], ax);            /* mov [edx+0x17], ax */
            ii(0x1016_38ed, 5); mov(edx, StringDefinitions.Storage3);   /* mov edx, 0x101b2a57 */
            ii(0x1016_38f2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_38f5, 5); call(0x1014_60aa, -0x1_d850);           /* call 0x101460aa */
            ii(0x1016_38fa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_38fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_38ff, 4); mov(memw[ds, eax + 25], dx);            /* mov [eax+0x19], dx */
            ii(0x1016_3903, 5); mov(edx, StringDefinitions.Ammo7);      /* mov edx, 0x101b2a5f */
            ii(0x1016_3908, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_390b, 5); call(0x1014_60aa, -0x1_d866);           /* call 0x101460aa */
            ii(0x1016_3910, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_3912, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3915, 4); mov(memw[ds, eax + 27], dx);            /* mov [eax+0x1b], dx */
            ii(0x1016_3919, 5); mov(edx, StringDefinitions.AttackRadius); /* mov edx, 0x101b2a64 */
            ii(0x1016_391e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3921, 5); call(0x1014_60aa, -0x1_d87c);           /* call 0x101460aa */
            ii(0x1016_3926, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_3928, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_392b, 4); mov(memw[ds, eax + 29], dx);            /* mov [eax+0x1d], dx */
            ii(0x1016_392f, 5); mov(edx, StringDefinitions.AgentAdjust); /* mov edx, 0x101b2a72 */
            ii(0x1016_3934, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3937, 5); call(0x1014_60aa, -0x1_d892);           /* call 0x101460aa */
            ii(0x1016_393c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_393e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3941, 4); mov(memw[ds, eax + 31], dx);            /* mov [eax+0x1f], dx */
            ii(0x1016_3945, 5); mov(edx, StringDefinitions.Version);    /* mov edx, 0x101b2a7f */
            ii(0x1016_394a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_394d, 5); call(0x1014_60aa, -0x1_d8a8);           /* call 0x101460aa */
            ii(0x1016_3952, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_3954, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3957, 4); mov(memw[ds, eax + 33], dx);            /* mov [eax+0x21], dx */
            ii(0x1016_395b, 5); mov(edx, StringDefinitions.UnitsBuilt2); /* mov edx, 0x101b2a87 */
            ii(0x1016_3960, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3963, 5); call(0x1014_60aa, -0x1_d8be);           /* call 0x101460aa */
            ii(0x1016_3968, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_396a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_396d, 3); mov(memb[ds, eax + 35], dl);            /* mov [eax+0x23], dl */
            ii(0x1016_3970, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3972, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_3973, 1); pop(edi);                               /* pop edi */
            ii(0x1016_3974, 1); pop(esi);                               /* pop esi */
            ii(0x1016_3975, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_3976, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_3977, 1); ret();                                  /* ret */
        }
    }
}
