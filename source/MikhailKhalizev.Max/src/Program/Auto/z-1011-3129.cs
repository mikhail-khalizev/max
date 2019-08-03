using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7134b621-f2fe-4c21-9f53-4d160b188e93")]
        public void Method_1011_3129()
        {
            ii(0x1011_3129, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_312e, 5); calld(Definitions.sys_check_available_stack_size, 0x52c1f); /* call 0x10165d52 */
            ii(0x1011_3133, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_3134, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_3135, 1); pushd(esi);                             /* push esi */
            ii(0x1011_3136, 1); pushd(edi);                             /* push edi */
            ii(0x1011_3137, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_3138, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_313a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_3140, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_3143, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_3146, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_314a, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_314d, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3150, 6); mov(al, memb_a32[ds, eax + 0x520]);     /* mov al, [eax+0x520] */
            ii(0x1011_3156, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_315b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_315d, 2); if(jzd(0x1011_31c1, 0x62)) goto l_0x1011_31c1; /* jz 0x101131c1 */
            ii(0x1011_315f, 5); mov(edx, 0x101a_4812);                  /* mov edx, 0x101a4812 */ /* "<" */
            ii(0x1011_3164, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_3168, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_316b, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_316e, 6); add(ebx, 0x338);                        /* add ebx, 0x338 */
            ii(0x1011_3174, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_3176, 5); calld(Definitions.sys_strcpy, 0x52d54); /* call 0x10165ecf */
            ii(0x1011_317b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_317f, 3); imul(edx, edx, 0x1e);                   /* imul edx, edx, 0x1e */
            ii(0x1011_3182, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3185, 5); add(eax, 0x520);                        /* add eax, 0x520 */
            ii(0x1011_318a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_318c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_3190, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_3193, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_3196, 6); add(ebx, 0x338);                        /* add ebx, 0x338 */
            ii(0x1011_319c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_319e, 5); calld(Definitions.sys_strcat, 0x52d8e); /* call 0x10165f31 */
            ii(0x1011_31a3, 5); mov(edx, 0x101a_4814);                  /* mov edx, 0x101a4814 */ /* ">" */
            ii(0x1011_31a8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_31ac, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_31af, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_31b2, 6); add(ebx, 0x338);                        /* add ebx, 0x338 */
            ii(0x1011_31b8, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_31ba, 5); calld(Definitions.sys_strcat, 0x52d72); /* call 0x10165f31 */
            ii(0x1011_31bf, 2); jmpd(0x1011_31e9, 0x28); goto l_0x1011_31e9; /* jmp 0x101131e9 */
        l_0x1011_31c1:
            ii(0x1011_31c1, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_31c5, 3); imul(edx, edx, 0x1e);                   /* imul edx, edx, 0x1e */
            ii(0x1011_31c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_31cb, 5); add(eax, 0x520);                        /* add eax, 0x520 */
            ii(0x1011_31d0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_31d2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_31d6, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_31d9, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_31dc, 6); add(ebx, 0x338);                        /* add ebx, 0x338 */
            ii(0x1011_31e2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_31e4, 5); calld(Definitions.sys_strcpy, 0x52ce6); /* call 0x10165ecf */
        l_0x1011_31e9:
            ii(0x1011_31e9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_31ed, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_31ef, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_31f2, 9); mov(memw_a32[ds, eax + 0x4dc], 0);      /* mov word [eax+0x4dc], 0x0 */
            ii(0x1011_31fb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_31ff, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3202, 7); mov(memb_a32[ds, eax + 0x4ec], 0);      /* mov byte [eax+0x4ec], 0x0 */
            ii(0x1011_3209, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_320b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_320c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_320d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_320e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_320f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3210, 1); retd(); return;                         /* ret */
        }
    }
}