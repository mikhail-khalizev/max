using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("702fca18-36b5-4082-91aa-fbbc1cbd4fdd")]
        public void Method_100d_42d8()
        {
            ii(0x100d_42d8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_42dd, 5); calld(Definitions.sys_check_available_stack_size, 0x9_1a70); /* call 0x10165d52 */
            ii(0x100d_42e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_42e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_42e4, 1); pushd(edx);                             /* push edx */
            ii(0x100d_42e5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_42e6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_42e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_42e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_42ea, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_42f0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_42f3, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x100d_42f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_42fb, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x100d_4301, 5); calld(0x100d_5134, 0xe2e);              /* call 0x100d5134 */
            ii(0x100d_4306, 5); mov(edx, 0x73e8);                       /* mov edx, 0x73e8 */
            ii(0x100d_430b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_430e, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x100d_4314, 5); calld(0x100d_5164, 0xe4b);              /* call 0x100d5164 */
            ii(0x100d_4319, 5); mov(edx, 0x3e9);                        /* mov edx, 0x3e9 */
            ii(0x100d_431e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4321, 6); mov(eax, memd_a32[ds, eax + 0x9d]);     /* mov eax, [eax+0x9d] */
            ii(0x100d_4327, 5); calld(0x100d_5134, 0xe08);              /* call 0x100d5134 */
            ii(0x100d_432c, 5); mov(edx, 0x73e9);                       /* mov edx, 0x73e9 */
            ii(0x100d_4331, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4334, 6); mov(eax, memd_a32[ds, eax + 0x9d]);     /* mov eax, [eax+0x9d] */
            ii(0x100d_433a, 5); calld(0x100d_5164, 0xe25);              /* call 0x100d5164 */
            ii(0x100d_433f, 5); mov(edx, 0x3ea);                        /* mov edx, 0x3ea */
            ii(0x100d_4344, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4347, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_434d, 5); calld(0x100d_5164, 0xe12);              /* call 0x100d5164 */
            ii(0x100d_4352, 5); mov(edx, 0x3eb);                        /* mov edx, 0x3eb */
            ii(0x100d_4357, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_435a, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_4360, 5); calld(0x100d_5134, 0xdcf);              /* call 0x100d5134 */
            ii(0x100d_4365, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_436a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_436d, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_4373, 5); calld(0x100d_5194, 0xe1c);              /* call 0x100d5194 */
            ii(0x100d_4378, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100d_437d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4380, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x100d_4386, 5); calld(0x100d_50d4, 0xd49);              /* call 0x100d50d4 */
            ii(0x100d_438b, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100d_4390, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4393, 6); mov(eax, memd_a32[ds, eax + 0x9d]);     /* mov eax, [eax+0x9d] */
            ii(0x100d_4399, 5); calld(0x100d_50d4, 0xd36);              /* call 0x100d50d4 */
            ii(0x100d_439e, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_43a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_43a6, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_43ac, 5); calld(0x100d_50d4, 0xd23);              /* call 0x100d50d4 */
            ii(0x100d_43b1, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x100d_43b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_43b9, 6); mov(eax, memd_a32[ds, eax + 0x95]);     /* mov eax, [eax+0x95] */
            ii(0x100d_43bf, 5); calld(0x100c_f2ba, -0x510a);            /* call 0x100cf2ba */
            ii(0x100d_43c4, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x100d_43c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_43cc, 6); mov(eax, memd_a32[ds, eax + 0x99]);     /* mov eax, [eax+0x99] */
            ii(0x100d_43d2, 5); calld(0x100c_f2ba, -0x511d);            /* call 0x100cf2ba */
            ii(0x100d_43d7, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_43dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_43df, 6); mov(eax, memd_a32[ds, eax + 0x95]);     /* mov eax, [eax+0x95] */
            ii(0x100d_43e5, 5); calld(0x100d_50d4, 0xcea);              /* call 0x100d50d4 */
            ii(0x100d_43ea, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_43ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_43f2, 6); mov(eax, memd_a32[ds, eax + 0x99]);     /* mov eax, [eax+0x99] */
            ii(0x100d_43f8, 5); calld(0x100d_50d4, 0xcd7);              /* call 0x100d50d4 */
            ii(0x100d_43fd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_4400, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_4403, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4406, 6); mov(eax, memd_a32[ds, eax + 0x9d]);     /* mov eax, [eax+0x9d] */
            ii(0x100d_440c, 5); calld(0x100c_f85c, -0x4bb5);            /* call 0x100cf85c */
            ii(0x100d_4411, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_4414, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_4417, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_441a, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x100d_4420, 5); calld(0x100c_f85c, -0x4bc9);            /* call 0x100cf85c */
            ii(0x100d_4425, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4428, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_442b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_442e, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_4434, 5); calld(0x100c_f85c, -0x4bdd);            /* call 0x100cf85c */
            ii(0x100d_4439, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_443c, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x100d_443f, 5); calld(0x100d_5440, 0xffc);              /* call 0x100d5440 */
            ii(0x100d_4444, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4446, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_4448, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_444b, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_4451, 5); calld(0x100c_fb73, -0x48e3);            /* call 0x100cfb73 */
            ii(0x100d_4456, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4459, 6); mov(eax, memd_a32[ds, eax + 0x8d]);     /* mov eax, [eax+0x8d] */
            ii(0x100d_445f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4462, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4465, 3); mov(edx, memd_a32[ds, eax + 0x40]);     /* mov edx, [eax+0x40] */
            ii(0x100d_4468, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_446b, 3); calld_abs(memd_a32[ds, edx + 0x10]);    /* call dword [edx+0x10] */
            ii(0x100d_446e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4471, 5); calld(0x100d_1447, -0x302f);            /* call 0x100d1447 */
            ii(0x100d_4476, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4479, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_447e, 5); calld(Definitions.my_2_get_count, -0x4_911b); /* call 0x1008b368 */
            ii(0x100d_4483, 1); cwde();                                 /* cwde */
            ii(0x100d_4484, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_4486, 2); if(jled(0x100d_44a1, 0x19)) goto l_0x100d_44a1; /* jle 0x100d44a1 */
            ii(0x100d_4488, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_448b, 6); mov(eax, memd_a32[ds, eax + 0x8d]);     /* mov eax, [eax+0x8d] */
            ii(0x100d_4491, 5); calld(0x100d_0149, -0x434d);            /* call 0x100d0149 */
            ii(0x100d_4496, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_4499, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_449c, 5); calld(0x100d_19a4, -0x2afd);            /* call 0x100d19a4 */
        l_0x100d_44a1:
            ii(0x100d_44a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_44a3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_44a4, 1); popd(edi);                              /* pop edi */
            ii(0x100d_44a5, 1); popd(esi);                              /* pop esi */
            ii(0x100d_44a6, 1); popd(edx);                              /* pop edx */
            ii(0x100d_44a7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_44a8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_44a9, 1); retd(); return;                         /* ret */
        }
    }
}
