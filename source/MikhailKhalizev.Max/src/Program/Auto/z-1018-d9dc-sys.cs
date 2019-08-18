using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b45e5670-37db-4a9e-9845-998e5d069c21")]
        public void /* sys */ Method_1018_d9dc()
        {
            ii(0x1018_d9dc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_d9dd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d9de, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d9df, 1); pushd(esi);                             /* push esi */
            ii(0x1018_d9e0, 1); pushd(edi);                             /* push edi */
            ii(0x1018_d9e1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_d9e2, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_d9e5, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1018_d9e7, 5); mov(eax, memd_a32[ds, 0x101b_e564]);    /* mov eax, [0x101be564] */
            ii(0x1018_d9ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d9ee, 5); calld(/* sys */ 0x1018_da9d, 0xaa);     /* call 0x1018da9d */
            ii(0x1018_d9f3, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1018_d9f6, 1); inc(eax);                               /* inc eax */
            ii(0x1018_d9f7, 6); mov(edx, memd_a32[ds, 0x101b_e564]);    /* mov edx, [0x101be564] */
            ii(0x1018_d9fd, 4); mov(memd_a32[ss, esp + 0x8], eax);      /* mov [esp+0x8], eax */
            ii(0x1018_da01, 2); sub(ecx, edx);                          /* sub ecx, edx */
            ii(0x1018_da03, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_da06, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_da07, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1018_da0b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1018_da0e, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1018_da10, 5); calld(Definitions.sys_malloc, -0x2_2a37); /* call 0x1016afde */
            ii(0x1018_da15, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_da17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_da19, 2); if(jzd(0x1018_da76, 0x5b)) goto l_0x1018_da76; /* jz 0x1018da76 */
            ii(0x1018_da1b, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1018_da1d, 6); mov(esi, memd_a32[ds, 0x101b_e564]);    /* mov esi, [0x101be564] */
            ii(0x1018_da23, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1018_da25, 2); mov(edi, ebp);                          /* mov edi, ebp */
            ii(0x1018_da27, 5); mov(memd_a32[ds, 0x101b_e1fc], eax);    /* mov [0x101be1fc], eax */
            ii(0x1018_da2c, 1); pushd(es);                              /* push es */
            ii(0x1018_da2d, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_da2f, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1018_da31, 1); pushd(edi);                             /* push edi */
            ii(0x1018_da32, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_da34, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1018_da37, 2); repne_a32(() => movsd_a32());           /* repne movsd */
            ii(0x1018_da39, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1018_da3b, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1018_da3e, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1018_da40, 1); popd(edi);                              /* pop edi */
            ii(0x1018_da41, 1); popd(es);                               /* pop es */
            ii(0x1018_da42, 6); mov(ecx, memd_a32[ds, 0x101b_e1fc]);    /* mov ecx, [0x101be1fc] */
            ii(0x1018_da48, 5); mov(eax, memd_a32[ds, 0x101b_e568]);    /* mov eax, [0x101be568] */
            ii(0x1018_da4d, 3); lea(edx, ecx + 0x4);                    /* lea edx, [ecx+0x4] */
            ii(0x1018_da50, 2); mov(memd_a32[ds, ecx], eax);            /* mov [ecx], eax */
            ii(0x1018_da52, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_da54, 4); mov(esi, memd_a32[ss, esp + 0x4]);      /* mov esi, [esp+0x4] */
            ii(0x1018_da58, 5); calld(/* sys */ 0x1018_da9d, 0x40);     /* call 0x1018da9d */
            ii(0x1018_da5d, 6); mov(ecx, memd_a32[ds, 0x101b_e1fc]);    /* mov ecx, [0x101be1fc] */
            ii(0x1018_da63, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1018_da67, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1018_da69, 5); mov(memd_a32[ds, 0x101b_e1f8], eax);    /* mov [0x101be1f8], eax */
            ii(0x1018_da6e, 6); mov(memd_a32[ds, ecx], 0);              /* mov dword [ecx], 0x0 */
            ii(0x1018_da74, 2); jmpd(0x1018_da80, 0xa); goto l_0x1018_da80; /* jmp 0x1018da80 */
        l_0x1018_da76:
            ii(0x1018_da76, 5); mov(memd_a32[ds, 0x101b_e1fc], eax);    /* mov [0x101be1fc], eax */
            ii(0x1018_da7b, 5); mov(memd_a32[ds, 0x101b_e1f8], eax);    /* mov [0x101be1f8], eax */
        l_0x1018_da80:
            ii(0x1018_da80, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1018_da84, 5); mov(memd_a32[ds, 0x1020_bd40], eax);    /* mov [0x1020bd40], eax */
            ii(0x1018_da89, 5); mov(eax, memd_a32[ds, 0x101b_e1fc]);    /* mov eax, [0x101be1fc] */
            ii(0x1018_da8e, 5); mov(memd_a32[ds, 0x1020_bd44], eax);    /* mov [0x1020bd44], eax */
            ii(0x1018_da93, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1018_da96, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_da97, 1); popd(edi);                              /* pop edi */
            ii(0x1018_da98, 1); popd(esi);                              /* pop esi */
            ii(0x1018_da99, 1); popd(edx);                              /* pop edx */
            ii(0x1018_da9a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_da9b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_da9c, 1); retd(); return;                         /* ret */
        }
    }
}
